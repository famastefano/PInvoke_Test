#include "Header.h"

extern "C" {
    int add(int x, int y)
    {
        return x + y;
    }
    int sub(int x, int y)
    {
        return x - y;
    }
    int add_array(int* x, int len)
    {
        int res = 0;

        for (int i = 0; i < len; ++i)
            res = add(res, x[i]);

        return res;
    }
    int sub_array(int* x, int len)
    {
        int res = 0;

        for (int i = 0; i < len; ++i)
            res = sub(res, x[i]);

        return res;
    }
}