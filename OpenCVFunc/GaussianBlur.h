#pragma once

#include "FilterBase.h"

namespace OpenCVFunc
{
	public ref class GaussianBlur : public FilterBase
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


			cv::Mat* outImage = new cv::Mat();
			cv::Mat dst = cv::Mat();
			cv::Mat src = cv::Mat();

			getImages(inImage, outImage, &src, &dst);

			try {
				cv::GaussianBlur(src, dst, ksize, sigmaX, sigmaY, borderType);
			}
			catch (...) {
				delete (outImage);
				throw;
			}


			ImageMemManager::SetImage(outImage, imageOutNo);

			String^ retStr = Util::GetInOutParam(inImage, outImage);
			inImage = NULL;
			return  retStr;

		}
	};

}

