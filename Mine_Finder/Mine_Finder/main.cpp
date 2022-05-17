#include "Mine.h"
#include <iostream>
#include <ctime>
using namespace std;
void print_map(MINE** map, int, int);
void make_mine(MINE** map, int, int);
void find_zero(MINE** map, int,int,int,int);
bool check_win(MINE** map, int, int);


void main() {
	srand(time(NULL));
	int x = 10, y = 10;
	bool loop = true;
	while (loop) {
		cout << "게임의 사이즈를 입력하세요. (예시 : '10 20') >>>";
		cin >> x >> y;
		if (x < 10 || y < 10) {
			cout << "게임의 최소 사이즈는 10 * 10 입니다." << endl;
			loop = true;
		}
		else
			loop = false;
	}
	
	MINE **map = new MINE*[y];
	for (int i = 0; i < y; i++) {
		map[i] = new MINE[x];
	}
	make_mine(map, x, y);
	print_map(map, x, y);

	loop = true;
	while (loop) {
		int ix = 0, iy = 0;
		cout << "좌표를 입력하세요. (예시 : '10 20') >>>";
		cin >> ix >> iy;
		if (map[iy][ix].ismine()){
			cout << "게임에서 졌습니다." << endl;
			loop = false;
			break;
		}
		if (map[iy][ix].value == 0)
			find_zero(map, x, y,iy, ix);
		print_map(map, x, y);
		if (check_win(map, x, y)) {
			loop = false;
			cout << "게임에서 승리하였습니다." << endl;
			break;
		}
	}
	getchar();
	getchar();
	delete[] map;
}

void print_map(MINE **map,int x,int y) {
	for (int i = 0; i < y; i++) {
		for (int j = 0; j < x; j++) {
			if (map[i][j].get_value() < 0)
				cout << '*' << ' ';
			else
				cout << map[i][j].get_value() << ' ';
		} 
		cout << endl;
	}
}
bool check_win(MINE** map, int x, int y) {
	int left = 0;
	for (int i = 0; i < y; i++) {
		for (int j = 0; j < x; j++) {
			if (map[i][j].value > 0 && !map[i][j].visible)
				left++;
		} 
	}

	if (left == 0)
		return true;
	else
		return false;
}

void make_mine(MINE** map, int x, int y) {
	int rx = 0, ry = 0, mine = 0, sx, sy;
	mine = (x * y) / 8;
	while (mine > 0) {
		rx = rand() % x;
		ry = rand() % y;
		if (map[ry][rx].value < 0)
			continue;
		map[ry][rx].value = -15;
		for (int i = rx - 1; i <= rx + 1; i++) {
			for (int j = ry - 1; j <= ry + 1; j++) {
				if (i == rx && j == ry)
					continue;
				if (i >= 0 && j >= 0 && i < x && j < y)
					map[j][i].value++;
			}
		}
		mine--;
	}
}

void find_zero(MINE** map, int x, int y, int iy, int ix) {
	for (int i = ix - 1; i <= ix + 1; i++) {
		for (int j = iy - 1; j <= iy + 1; j++) {
			if (i == ix && j == iy)
				continue;
			if (i >= 0 && j >= 0 && i < x && j < y)
				if (map[j][i].value == 0 && !map[j][i].visible) {
					map[j][i].visible = true;
					find_zero(map, x, y, j, i);
				}
				else
					map[j][i].visible = true;

		}
	}
}