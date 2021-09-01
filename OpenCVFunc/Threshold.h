#pragma once


#include "FilterBase.h"

using namespace System;
using namespace System::Collections::Generic;

namespace OpenCVFunc {
	public ref class Threshold : public FilterBase
	{
		// TODO: このクラスのメソッドをここに追加します。
	public:
		String^ threshold_exec(double thresh, double maxval, int type,int imageInNo, int imageOutNo)
		{
			cv::Mat* inImage = ImageMemManager::GetImage(imageInNo);
			if (inImage == nullptr) { return "no input image"; }
			
			cv::Mat* outImage = new cv::Mat();
			cv::Mat dst = cv::Mat();
			cv::Mat src = cv::Mat();

			getImages(inImage, outImage, &src, &dst);

			try {
				cv::threshold(src, dst, thresh, maxval, type);
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
