#pragma once

#include "Util.h"


namespace OpenCVFunc {
	public ref class Median
	{
	public:
		String^ MedianBlur_exec(
			int kernelSize,
			int imageInNo,
			int imageOutNo)
		{

			cv::Mat* inImage = ImageMemManager::GetImage(imageInNo);
			if (inImage == nullptr) { return "no input image"; }

			cv::Mat* outImage = new cv::Mat;
			try {
				cv::medianBlur(*inImage, *outImage, kernelSize);
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
