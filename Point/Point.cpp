#include "Point.h"

miit::point::Point::Point(const int x, const int y)
	: abscissa(x), ordinate(y)
{
}

const int miit::point::Point::Abscissa() const
{
	return this->abscissa;
}

const int miit::point::Point::Ordinate() const
{
	return this->ordinate;
}
