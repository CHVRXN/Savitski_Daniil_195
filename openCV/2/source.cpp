#include <opencv2/core/core.hpp>
#include <opencv2/highgui/highgui.hpp>
#include <opencv2/imgproc/imgproc.hpp>
#include <stdio.h>
#include <stdlib.h>
#include <string>
#include <iostream>
using namespace cv;
using namespace std;

Mat img;
int main()	
{
	setlocale(LC_ALL, "Russian");
	char filename[80];
	cout << "Введите название файла и нажмите enter" << endl;
	cout << "file.jpg" << endl;
	cout << "sf.jpg" << endl;
	cout << "road.png" << endl;

	cin.getline(filename, 80);
	cout << "Открыть файл: ";
	cout << filename << endl;

	Mat img = imread(filename, 1);
	const char* source_window =  filename;

	namedWindow(source_window, WINDOW_AUTOSIZE);
	imshow(source_window, img);

	waitKey(0);
	return(0);

}
