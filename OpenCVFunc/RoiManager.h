#pragma once
#include <opencv2/opencv.hpp>
#include <msclr/marshal_cppstd.h>

using namespace System;
using namespace System::Collections::Generic;



namespace OpenCVFunc {

	static public ref class RoiManager
	{
	public:
		static void Initialize() {
			enableList = gcnew array<bool>(MAX_NUM);
			rois = (cv::Rect**)new cv::Rect * [MAX_NUM];

			for (size_t i = 0; i < MAX_NUM; i++)
			{
				rois[i] = new cv::Rect(0,0,100,100);
			}
		}

		static void SetRoi(int x, int y, int width, int height, int roiNo) {
			SetRoi(new cv::Rect(x, y, width, height), roiNo);
		}

		static void SetRoi(cv::Rect* roi, int roiNo) {
			if (roi == nullptr) { return; }

			if (rois == nullptr) { Initialize(); }

			if (roiNo > MAX_NUM) { return; }
			if (*(rois + roiNo) != nullptr) {
				delete* (rois + roiNo);
			}
			*(rois + roiNo) = roi;
		}

		static cv::Rect* GetRoi(int roiNo) {

			if (rois == nullptr) { Initialize(); }

			return *(rois + roiNo);
		}

		static void Close() {
			cv::destroyAllWindows();

			for (int i = 0; i < MAX_NUM; i++)
			{
				if (enableList[i] == true) {
					delete* (rois + i);
					rois[i] = nullptr;
				}
			}
			if (rois != nullptr)
			{
				delete[] rois;
				rois = nullptr;
			}
		}


	private:
		static array<bool>^ enableList = nullptr;
		static cv::Rect** rois = nullptr;
		static const int MAX_NUM = 10;

	};
}
