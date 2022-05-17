#include "Mine.h"


bool MINE::ismine() {
	if (value < 0) {
		return true;
	}
	else
		visible = true;
		return false;

}
MINE::MINE() {
	value = 0;
	visible = false;
}
int MINE::get_value() {
	if (visible)
		return value;
	else
		return -100;
	
}