#pragma once

#include "Util.h"

namespace OpenCVFunc {
	public ref class Blur
	{
	public:
		String^ Blur_exec(
			int kernelX,
			int kernelY,
			int anchorX,
			int anchorY,
			int borderType,
			int imageInNo,
			int imageOutNo
			)
		{
			cv::Mat* inImage = ImageMemManager::GetImage(imageInNo);
			if (inImage == nullptr) { return "no input image"; }

			cv::Mat* outImage = new cv::Mat;
			try {
				cv::blur(*inImage, *outImage, cv::Size(kernelX, kernelY), cv::Point(anchorX, anchorY), borderType);
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
