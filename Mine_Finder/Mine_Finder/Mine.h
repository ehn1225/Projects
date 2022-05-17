#ifndef MINE_H
#define MINE_H

class MINE {
public:
	int value;
	bool ismine();
	bool visible;
	MINE();
	int get_value();
};

#endif // !MINE_H
