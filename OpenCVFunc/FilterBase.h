#pragma once


#include "Util.h"
#include "RoiManager.h"

namespace OpenCVFunc {

	public ref class FilterBase
	{
	public:
		FilterBase() {

		}

		void SetRoi(int roiNo, bool isFrameMode) {
			this->roiNo = roiNo;
			this->isFrameMode = isFrameMode;


		}

	protected:
		int roiNo = 0;
		bool isFrameMode = false;

		void checkRoi(cv::Mat inImage, cv::Rect* roi) {
			int h = inImage.rows;
			int w = inImage.cols;

			if (roi->x >= w) roi->x = w - 1;
			if (roi->y >= h)roi->y = h - 1;
			if ((roi->x + roi->width) > w)
				roi->width = w - roi->x;
			if ((roi->y + roi->height) > h)
				roi->height = h - roi->y;
		}

		void getImages(cv::Mat* inImage, cv::Mat* outImage, cv::Mat* src, cv::Mat* dst) {
			
			if (roiNo != 0) {
				cv::Rect* r = (RoiManager::GetRoi(roiNo));
				if (r == nullptr) {
					*src = *inImage;
					*dst = *outImage;
					return;
				}

				cv::Rect roi = cv::Rect(*r);
				checkRoi(*inImage, &roi);
				*src = ((*inImage)(roi));


				if (isFrameMode == true) {
					inImage->copyTo(*outImage);
					*dst = ((*outImage)(roi));
				}
				else {
					src->copyTo(*outImage);
					*dst = (*outImage);
				}
			}
			else {
				*src = *inImage;
				inImage->copyTo(*outImage);
				*dst = (*outImage);
			}
		}
	};

}