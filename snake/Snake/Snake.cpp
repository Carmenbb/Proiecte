// Snake.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <conio.h>
#include <Windows.h>
using namespace std;

struct Obiect {
    int x;
    int y;
};

enum Directie
{
    STOP,
    LEFT,
    RIGHT,
    UP,
    DOWN,

};

bool GameOver;
int height;
int width;
Obiect snake;
Obiect mancare;
Obiect coada[200];
Directie dir;
int scor=0;
int ncoada = 0;

void SetUp() {
    GameOver=false;
    height = 15;
    width = 30;
    snake.x = 5;
    snake.y = 5;
    mancare.x = rand() % width;
    mancare.y = rand() % height;
    dir = STOP;

 }

//desenare caractere si actualizare pozitie
void Draw() {
    system("cls"); //curatare consola

    //partea de sus
    for (int i = 0;i < width; i++)
        cout << "=";
      cout << "\n";
    
    //mijloc
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (j == 0 || j == width - 1)
                cout << "=";
            else
                if (i == snake.y && j == snake.x)
                    cout << "O";
                else
                    if (i == mancare.y && j == mancare.x)
                        cout << "*";

                    else 
                    {
                        bool ecoada = false;
                        for (int k = 0;k <= ncoada;k ++)
                        {
                            if (coada[k].x == j && coada[k].y == i)
                            {
                                ecoada = true;
                                break;
                            }                     
                        }
                        if (!ecoada)
                            cout << " ";
                        else
                            cout << "o";

                    }
                        cout << " ";
        }
       
        cout << "\n";
    }
    //partea de jos
    for (int i = 0; i < width; i++)
        cout << "=";
     
    cout << "\n";
    cout << "SCOR: " << scor;

}

void Imput() {
    if (_kbhit())
    {
        switch (_getch())
        {
        case 'a': dir = LEFT; break;
        case 's': dir = DOWN; break;
        case 'd': dir = RIGHT; break;
        case 'w': dir = UP; break;
        }
    }
}

void Logic() {
    switch (dir)
    {

    case LEFT:snake.x--;
        break;
    case RIGHT:snake.x++;
        break;
    case UP:snake.y--;
        break;
    case DOWN:snake.y++;
        break;

    }
    //marirea cozii
    int xprev, yprev, xprev2, yprev2;
    xprev = snake.x;
    yprev = snake.y;
    
    for (int i = 0; i <= ncoada; i++)
    {
        xprev2 = coada[i].x;
        yprev2 = coada[i].y;
        coada[i].x = xprev;
        coada[i].y = yprev;
        xprev = xprev2;
        yprev = yprev2;
    }
    
    if (snake.x == mancare.x && snake.y == mancare.y)
    {
        scor++;
        ncoada++;
        mancare.x = rand() % width;
        mancare.y = rand() % height;

    }
    //GameOver
    if (snake.x == 0)
        GameOver = true;

    if (snake.y == 0)
        GameOver = true;

    if (snake.x == width)
        GameOver = true;

    if (snake.y == height)
        GameOver = true;

    for (int i = 1; i <=ncoada; i++)
    {
        if (snake.x == coada[i].x && snake.y == coada[i].y)
        {
            GameOver = true;
            break;
        }
    }
}

int main()
{
    SetUp();
    while (!GameOver)
    {
        Imput();
        Logic();
        Draw();
        Sleep(40);
   
    }
    return 0;

}
