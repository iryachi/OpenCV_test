#pragma once

#include "Util.h"

namespace OpenCVFunc
{
	public ref class GaussianBlur
	{
	public:
		String^ GaussianBlur_exec(
			int kernelSizeX,
			int kernelSizeY,
			double sigmaX,
			double sigmaY,
			int borderType,
			int imageInNo,
			int imageOutNo)
		{
			cv::Mat* inImage = ImageMemManager::GetImage(imageInNo);
			if (inImage == nullptr) { return "no input image"; }

			cv::Size ksize(kernelSizeX, kernelSizeY);

			cv::Mat* outImage = new cv::Mat;
			try {
				cv::GaussianBlur(*inImage, *outImage, ksize, sigmaX, sigmaY, borderType);
			}
			catch (...) {
				delete (outImage);
				throw;
			}


			ImageMemManager::SetImage(outImage, imageOutNo);


			return Util::GetInOutParam(inImage, outImage);

		}
	};

}

