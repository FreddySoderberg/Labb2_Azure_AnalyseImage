using System;
using System.Collections.Generic;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace Labb2_Azure_AnalyseImage
{
    class AnalyseUrlImage
    {
        //https://cdn.pixabay.com/photo/2017/11/11/21/55/freedom-2940655_960_720.jpg

        // Add your Computer Vision subscription key and endpoint
        static string subscriptionKey = "";
        static string endpoint = "";

        // Add URL temp
        private static string imageUrlString = "";

        public async Task StartAnalyseUrl(string url)
        {
            try
            {
                IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
                IConfigurationRoot configuration = builder.Build();
                endpoint = configuration["CognitiveServicesEndpoint"];
                subscriptionKey = configuration["CognitiveServiceKey"];


                imageUrlString = url;

                Console.WriteLine("Azure Cognitive Services Computer Vision - .NET quickstart example");
                Console.WriteLine();
                // Create a client
                ComputerVisionClient client = Authenticate(endpoint, subscriptionKey);
                await AnalyzeImageUrl(client, url);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static ComputerVisionClient Authenticate(string endpoint, string key)
        {
            ComputerVisionClient client =
              new ComputerVisionClient(new ApiKeyServiceClientCredentials(key))
              { Endpoint = endpoint };
            return client;
        }

        public static async Task AnalyzeImageUrl(ComputerVisionClient client, string imageUrl)
        {
            using (var imageFile = Image.FromFile("DownloadedImage.png"))
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("ANALYZE IMAGE - URL");
                Console.WriteLine();

                // Creating a list that defines the features to be extracted from the image. 

                List<VisualFeatureTypes?> features = new List<VisualFeatureTypes?>()
                {
                    VisualFeatureTypes.Description,
                    VisualFeatureTypes.Tags,
                    VisualFeatureTypes.Categories,
                    VisualFeatureTypes.Brands,
                    VisualFeatureTypes.Objects,
                    VisualFeatureTypes.Adult
                };

                Console.WriteLine($"Analyzing the image {Path.GetFileName(imageUrl)}...");
                Console.WriteLine();
                // Analyze the URL image 
                ImageAnalysis results = await client.AnalyzeImageAsync(imageUrl, visualFeatures: features);

                // Image tags and their confidence score
                Console.WriteLine("Tags:");
                foreach (ImageTag tag in results.Tags)
                {
                    Console.WriteLine($"{tag.Name} {tag.Confidence}");
                }
                Console.WriteLine();
                Console.WriteLine($"Analyzing {imageFile}");

                // Get image analysis
                using (var imageData = File.OpenRead("DownloadedImage.png"))
                {
                    var analysis = await client.AnalyzeImageInStreamAsync(imageData, features);

                    // get image captions
                    foreach (var caption in analysis.Description.Captions)
                    {
                        Console.WriteLine($"Description: {caption.Text} (confidence:{caption.Confidence.ToString("P")})");
                    }

                    // Get image tags
                    if (analysis.Tags.Count > 0)
                    {
                        Console.WriteLine("Tags:");
                        foreach (var tag in analysis.Tags)
                        {
                            Console.WriteLine($" -{tag.Name} (confidence: {tag.Confidence.ToString("P")})");
                        }
                    }

                    // Get image categories
                    List<LandmarksModel> landmarks = new List<LandmarksModel> { };
                    List<CelebritiesModel> celebrities = new List<CelebritiesModel> { };
                    Console.WriteLine("Categories:");

                    foreach (var category in analysis.Categories)
                    {
                        // Print the category
                        Console.WriteLine($" -{category.Name} (confidence: {category.Score.ToString("P")})");
                        // Get landmarks in this category
                        if (category.Detail?.Landmarks != null)
                        {
                            foreach (LandmarksModel landmark in category.Detail.Landmarks)
                            {
                                if (!landmarks.Any(item => item.Name == landmark.Name))
                                {
                                    landmarks.Add(landmark);
                                }
                            }
                        }
                        // Get celebrities in this category
                        if (category.Detail?.Celebrities != null)
                        {
                            foreach (CelebritiesModel celebrity in category.Detail.Celebrities)
                            {
                                if (!celebrities.Any(item => item.Name == celebrity.Name))
                                {
                                    celebrities.Add(celebrity);
                                }
                            }
                        }
                    }
                    // If there were landmarks, list them
                    if (landmarks.Count > 0)
                    {
                        Console.WriteLine("Landmarks:");
                        foreach (LandmarksModel landmark in landmarks)
                        {
                            Console.WriteLine($" -{landmark.Name} (confidence: {landmark.Confidence.ToString("P")})");
                        }
                    }
                    // If there were celebrities, list them
                    if (celebrities.Count > 0)
                    {
                        Console.WriteLine("Celebrities:");
                        foreach (CelebritiesModel celebrity in celebrities)
                        {
                            Console.WriteLine($" -{celebrity.Name} (confidence: {celebrity.Confidence.ToString("P")})");
                        }
                    }

                    // Get brands in the image
                    if (analysis.Brands.Count > 0)
                    {
                        Console.WriteLine("Brands:");
                        foreach (var brand in analysis.Brands)
                        {
                            Console.WriteLine($" -{brand.Name} (confidence: {brand.Confidence.ToString("P")})");
                        }
                    }
                    // Get objects in the image
                    if (analysis.Objects.Count > 0)
                    {
                        Console.WriteLine("Objects in image:");

                        // Prepare image for drawing
                        Image image = Image.FromFile("DownloadedImage.png");
                        Graphics graphics = Graphics.FromImage(image);
                        Pen pen = new Pen(Color.Cyan, 3);
                        Font font = new Font("Arial", 16);
                        SolidBrush brush = new SolidBrush(Color.Black);

                        foreach (var detectedObject in analysis.Objects)
                        {
                            // Print object name
                            Console.WriteLine($" -{detectedObject.ObjectProperty} (confidence: {detectedObject.Confidence.ToString("P")})");

                            // Draw object bounding box
                            var r = detectedObject.Rectangle;
                            Rectangle rect = new Rectangle(r.X, r.Y, r.W, r.H);
                            graphics.DrawRectangle(pen, rect);
                            graphics.DrawString(detectedObject.ObjectProperty, font, brush, r.X, r.Y);
                        }
                        // Save annotated image
                        if (System.IO.File.Exists("objectsUrl.png"))
                        {
                            System.IO.File.Delete("objectsUrl.png");
                        }
                        String output_file = "objectsUrl.png";
                        image.Save(output_file);
                        image.Dispose();
                    }

                    // Get moderation ratings
                    string ratings = $"Ratings:\n -Adult: {analysis.Adult.IsAdultContent}\n -Racy: {analysis.Adult.IsRacyContent}\n -Gore: {analysis.Adult.IsGoryContent}";
                }
            }
        }
    }
}

