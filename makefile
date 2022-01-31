all:
	g++ -Wall -Ofast -march=skylake -o gl_test main.cc src/glad.c -I include/ -lglfw -lGL -ldl -lm -lncurses -std=c++17 -fsingle-precision-constant -fno-rtti -fno-exceptions -fno-strict-aliasing
