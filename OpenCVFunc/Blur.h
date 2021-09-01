#pragma once

#include "FilterBase.h"

namespace OpenCVFunc {
	public ref class Blur : public FilterBase
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


			cv::Mat* outImage = new cv::Mat();
			cv::Mat dst = cv::Mat();
			cv::Mat src = cv::Mat();

			getImages(inImage, outImage, &src, &dst);

			try {
				cv::blur(src, dst, cv::Size(kernelX, kernelY), cv::Point(anchorX, anchorY), borderType);
			}
			catch (...) {
				inImage = NULL;
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
