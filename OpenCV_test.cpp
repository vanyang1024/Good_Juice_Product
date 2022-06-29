#include <opencv2/core/core.hpp>
#include <opencv2/highgui/highgui.hpp>
#include "opencv2/opencv.hpp"

using namespace cv;
using namespace std;

int main(void)
{
	Mat img = imread("C:/Users/Van/Desktop/capture.png", IMREAD_COLOR); //this api cant use
	//Mat img = Mat(300,300, CV_8UC3, Scalar(255, 255, 255)); //this ok
    // imwrite("./lenaload.jpg",img); //this api cant use
	if (img.empty())
	{
		std::cout << "Could not read the image" << std::endl;
		return 1;
	}
	std::cout << "Rows:" << img.rows << "Columns:" << img.channels() << std::endl;

	imshow("Display window", img);
	
	Mat gray,open,close;
	Mat kernel = cv::getStructuringElement(MORPH_RECT, Size(2, 2));

	while (true) {
		int k = waitKey(0); // Wait for a keystroke in the window
		if (k == 's')
		{
			imwrite("capture1.png", img);
			break;
		}
		if (k == 'g')
		{
			cvtColor(img, gray, COLOR_BGR2GRAY);
			//blur(gray, gray, Size(3, 3));
			threshold(gray, gray, 96, 255, THRESH_BINARY);
			erode(gray, open, kernel,cv::Point(-1,-1),2);
			dilate(gray, close, kernel, cv::Point(-1, -1), 2);
			//morphologyEx(gray, open, MORPH_OPEN, kernel);
			//morphologyEx(gray, close, MORPH_CLOSE, kernel);
			gray = close - open;
			imshow("Display win", gray);
			//imshow("Display window", close);
		}
		if (k == 'a')
		{
			img -= Scalar(30, 30, 30);
			imshow("Display window", img);
		}
		if (k == 'd')
		{

			img += Scalar(30, 30, 30);
			imshow("Display window", img);
		}

	}
	/*
	char* imgdata = new char[img.rows*img.cols*img.channels()];
	for (int i = 0; i < img.rows; i++)
	{
		unsigned char *data = img.ptr<unsigned char>(i);
		for (int j = 0; j < img.cols * 3; j++)
		{
			imgdata[i * img.cols * 3 + j] = data[j];
			std::cout << (int)data[j] << " ";
		}
	}
	cv::Mat Image(img.rows, img.cols, CV_8UC3, imgdata);
	imshow("2", Image);
	waitKey(0);
	*/
	return 0;

}

