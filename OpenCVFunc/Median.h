#pragma once


#include "FilterBase.h"


namespace OpenCVFunc {
	public ref class Median : public FilterBase
	{
	public:
		String^ MedianBlur_exec(
			int kernelSize,
			int imageInNo,
			int imageOutNo)
		{

			cv::Mat* inImage = ImageMemManager::GetImage(imageInNo);
			if (inImage == nullptr) { return "no input image"; }

			cv::Mat* outImage = new cv::Mat();
			cv::Mat dst = cv::Mat();
			cv::Mat src = cv::Mat();

			getImages(inImage, outImage, &src, &dst);


			try {
				cv::medianBlur(src, dst, kernelSize);
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
