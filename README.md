# BitmapOnnxPrediction

BitmapOnnxPrediction is a C# application that demonstrates how to classify bitmap images using a pre-trained ONNX model from Azure's Custom Vision service with the help of ML.NET.

The Custom Vision service is one of the Azure Cognitive Services provided by Microsoft.
With Custom Vision, you can train a model with your own image data.
While the portal provides a Prediction API to classify images, there might be scenarios where an offline model is preferred for reasons such as performance, connectivity, security, and costs.

## Features

- Load and preprocess images suitable for ONNX model prediction.
- Classify bitmap images using a pre-trained ONNX model.
- Display the classification label in the console.

## Getting Started

### Prerequisites

- .NET SDK
- Microsoft.ML NuGet package
- An ONNX model from the Azure Custom Vision portal.
  If you don't have a model yet, consider following the quickstart on "How to build a classifier with Custom Vision".

### Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/eNeRGy164/BitmapOnnxPrediction.git
   ```

2. Navigate to the project directory and build the solution:
   ```bash
   cd BitmapOnnxPrediction/src
   dotnet build
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

**Note**: Ensure you have the "model.onnx" file in the appropriate directory as indicated in the code.

## Steps Covered in the Blog Post

1. **Exporting the trained model**: Learn how to obtain the model from the custom vision portal.
2. **Setting up the application**: Get insights about setting up the application.
3. **Adding support classes**: Understand the necessary support classes for the application.
4. **Building the prediction engine**: Dive deep into how the prediction engine is constructed.
5. **Classifying a bitmap**: Follow the final steps to classify a bitmap.

For a detailed walkthrough, refer to the [blog post](https://blog.hompus.nl/2020/06/19/classify-a-bitmap-with-your-downloaded-custom-vision-onnx-model/).


## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
