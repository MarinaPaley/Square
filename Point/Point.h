#pragma once
namespace miit::point
{
	class Point
	{
	public:
		Point();
		Point(const int x, const int y);

	private:
		int x;
		int y;
	};
}