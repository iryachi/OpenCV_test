#pragma once
#include <opencv2/opencv.hpp>
#include <msclr/marshal_cppstd.h>

using namespace System;
using namespace System::Collections::Generic;


namespace OpenCVFunc {
	static public ref class ImageMemManager
	{

	public:
		static void Initialize() {
			if (images == nullptr){
				enableList = gcnew array<bool>(MAX_NUM);
				images = (cv::Mat**)new cv::Mat * [MAX_NUM];

				for (size_t i = 0; i < MAX_NUM; i++)
				{
					images[i] = nullptr;
				}
			}
		}
		static void SetImage(cv::Mat* image, int imageNo) {
			if (image == nullptr) { return; }

			if (images == nullptr) { Initialize(); }

			if (imageNo > MAX_NUM) { return; }
			if (*(images+imageNo) != nullptr) {
				delete *(images + imageNo);
			}
			*(images + imageNo) = image;
			std::string s = msclr::interop::marshal_as<std::string>("image : " + imageNo.ToString());
			cv::imshow(s, *image);
		}

		static cv::Mat* GetImage(int imageNo) {
			return *(images + imageNo);
		}
		
		static void Close() {
			cv::destroyAllWindows();

			for (int i = 0; i < MAX_NUM; i++)
			{
				if (enableList[i] == true) {
					delete *(images + i);
					images[i] = nullptr;
				}
			}
			if (images != nullptr)
			{
				delete[] images;
				images = nullptr;
			}
		}

	private:
		static array<bool>^ enableList = nullptr;
		static cv::Mat** images = nullptr;

		static const int MAX_NUM = 10;
	};

}

