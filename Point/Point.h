#pragma once
namespace miit::point
{
	class Point
	{
	public:
		explicit Point(const int x = 0, const int y = 0);

		const int Abscissa() const;
		const int Ordinate() const;

	private:
		int abscissa;
		int ordinate;
	};
}