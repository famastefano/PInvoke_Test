#pragma once

extern "C"
{
    int __declspec(dllexport) add(int x, int y);
    int __declspec(dllexport) sub(int x, int y);
    int __declspec(dllexport) add_array(int* x, int len);
    int __declspec(dllexport) sub_array(int* x, int len);
}