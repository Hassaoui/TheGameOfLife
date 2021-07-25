﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chooseLvl : MonoBehaviour
{
    //1
    private int[] _1x = { 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 47, 47, 47, 47, 48, 48, 48, 48, 49, 49 };
    private int[] _1y = { 0, 49, 1, 2, 47, 48, 0, 1, 48, 49, 0, 1, 48, 49, 1, 2, 47, 48, 0, 49 };

    //2
    private int[] _2x = { 17, 17, 17, 17, 18, 18, 18, 18, 19, 19, 19, 19, 19, 19, 20, 20, 20, 20, 21, 21, 21, 21, 22, 22, 22, 22, 23, 23, 23, 23, 23, 23, 24, 24, 24, 24, 25, 25, 25, 25 };
    private int[] _2y = { 24, 25, 29, 30, 23, 26, 28, 31, 23, 25, 26, 28, 29, 31, 22, 23, 31, 32, 24, 26, 28, 30, 22, 23, 31, 32, 23, 25, 26, 28, 29, 31, 23, 26, 28, 31, 24, 25, 29, 30 };

    //3
    private int[] _3x = { 82, 82, 82, 82, 82, 82, 83, 83, 83, 83, 84, 84, 85, 85, 85, 85, 86, 86, 86, 86, 87, 87, 87, 87, 88, 88, 89, 89, 90, 90, 90, 90, 91, 91, 92, 92, 92, 92, 93, 93, 93, 93, 94, 94, 94, 94, 94, 94, 94, 94, 95, 95, 95, 95, 95, 95, 96, 96, 96, 96, 97, 97, 97, 97, 97, 97, 98, 98, 98, 98, 98, 98, 99, 99, 99, 99 };
    private int[] _3y = { 1, 2, 3, 14, 15, 16, 1, 4, 13, 16, 1, 16, 1, 5, 12, 16, 1, 5, 12, 16, 2, 6, 11, 15, 7, 10, 8, 9, 5, 7, 10, 12, 5, 12, 6, 7, 10, 11, 4, 5, 12, 13, 3, 4, 5, 7, 10, 12, 13, 14, 2, 3, 6, 11, 14, 15, 2, 4, 13, 15, 3, 4, 5, 12, 13, 14, 3, 4, 5, 12, 13, 14, 3, 4, 13, 14 };

    //4
    private int[] _4x = { 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4 };
    private int[] _4y = { 6, 8, 11, 13, 2, 3, 5, 8, 11, 14, 16, 17, 6, 8, 11, 13 };

    //5
    private int[] _5x = { 2, 2, 2, 2, 2, 2, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 9, 9, 9, 9, 9, 9, 10, 10, 10, 10, 11, 11, 11, 11, 12, 12, 12, 12, 14, 14, 14, 14, 14, 14 };
    private int[] _5y = { 4, 5, 6, 10, 11, 12, 2, 7, 9, 14, 2, 7, 9, 14, 2, 7, 9, 14, 4, 5, 6, 10, 11, 12, 4, 5, 6, 10, 11, 12, 2, 7, 9, 14, 2, 7, 9, 14, 2, 7, 9, 14, 4, 5, 6, 10, 11, 12 };

    //6
    private int[] _6x = { 34, 34, 35, 35, 36, 36, 36, 36, 37, 37, 37, 37, 37, 38, 38, 38, 39, 39, 39, 41, 41, 41, 42, 42, 42, 42, 42, 42, 43, 43, 44, 44, 44, 45, 45, 46 };
    private int[] _6y = { 12, 13, 11, 13, 2, 3, 4, 13, 2, 3, 5, 6, 10, 7, 9, 10, 5, 6, 7, 4, 6, 10, 4, 5, 6, 8, 10, 11, 7, 11, 5, 11, 12, 5, 12, 11 };

    //7
    private int[] _7x = { 3, 3, 4, 4, 10, 10, 10, 11, 11, 11, 11, 12, 12, 12, 12, 13, 13, 13, 13, 13, 14, 14, 14, 14, 17, 17, 18, 18, 18, 18, 18, 19, 20, 20, 20, 21, 22, 22, 23, 23, 26, 26, 26, 26, 27, 27, 27, 27, 28, 28, 28, 28, 28, 29, 29, 29, 30, 37, 37, 38, 38 };
    private int[] _7y = { 40, 41, 40, 41, 40, 41, 42, 39, 40, 42, 43, 39, 40, 42, 43, 39, 40, 41, 42, 43, 38, 39, 43, 44, 41, 42, 39, 40, 41, 42, 43, 43, 39, 40, 41, 39, 40, 41, 40, 41, 40, 41, 45, 46, 40, 42, 44, 46, 41, 42, 43, 44, 45, 42, 43, 44, 43, 42, 43, 42, 43 };

    //8
    private int[] _8x = { 5, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 9 };
    private int[] _8y = { 6, 7, 8, 5, 9, 4, 10, 5, 9, 6, 7, 8 };

    //9
    private int[] _9x = { 14, 14, 14, 15, 15, 16, 16, 17, 18, 18, 18, 18, 18, 19, 20, 20, 20, 21, 24, 24, 25, 25, 26, 33, 34, 34, 34, 35, 35, 35, 35, 35, 38, 38, 38, 38, 38, 39, 39, 39, 39, 39, 40, 40, 40, 40, 41, 41, 41, 42, 42, 45, 45, 47, 47, 48, 49, 49, 49, 50, 50, 50, 51, 51, 51, 51, 51, 52, 52, 52, 52, 52, 53, 53, 53, 54, 54, 55, 55, 56, 56, 57, 57, 58, 58, 58, 58, 59, 62, 62, 62, 63, 63, 64, 64, 64, 64, 64, 64, 65, 65, 65, 66, 66, 66, 67, 67 };
    private int[] _9y = { 25, 26, 27, 25, 28, 24, 28, 29, 25, 26, 27, 29, 30, 29, 24, 28, 29, 28, 21, 23, 21, 22, 22, 4, 3, 21, 22, 3, 4, 5, 21, 22, 9, 10, 23, 24, 25, 9, 10, 12, 13, 15, 12, 13, 15, 27, 8, 14, 27, 7, 27, 6, 7, 14, 15, 13, 10, 12, 13, 11, 12, 19, 14, 16, 17, 18, 20, 14, 16, 17, 19, 20, 15, 24, 25, 24, 25, 16, 17, 15, 18, 18, 19, 14, 15, 16, 17, 15, 15, 16, 18, 15, 18, 16, 17, 18, 21, 22, 30, 20, 23, 30, 20, 23, 30, 21, 22 };

    //10
    private int[] _10x = { 50, 50, 50, 50, 50, 50, 51, 51, 51, 51, 52, 52, 53, 53, 54, 54, 54, 54, 56, 56, 56, 57, 57, 58, 58, 59, 59, 61, 61, 62, 62, 62, 63, 64, 64, 64, 65, 65, 65, 66, 66, 67, 68, 68, 69, 69, 69, 69, 69, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 71, 71, 71, 71, 71, 71, 71, 71, 71, 71, 71, 71, 71, 72, 72, 72, 72, 72, 72, 72, 72, 72, 72, 72, 72, 72, 72, 72, 72, 72, 73, 73, 73, 73, 73, 73, 73, 73, 74, 74, 74, 74, 74, 74, 75, 75, 75, 75, 75, 75, 75, 75, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 77, 77, 77, 77, 77, 77, 77, 77, 77, 77, 77, 77, 77, 78, 78, 78, 78, 78, 78, 78, 78, 78, 78, 79, 79, 79, 79, 79, 80, 80, 81, 82, 82, 83, 83, 83, 84, 84, 84, 85, 86, 86, 86, 87, 87, 89, 89, 90, 90, 91, 91, 92, 92, 92, 94, 94, 94, 94, 95, 95, 96, 96, 97, 97, 97, 97, 98, 98, 98, 98, 98, 98 };
    private int[] _10y = { 75, 76, 77, 83, 84, 85, 75, 78, 82, 85, 75, 85, 75, 85, 76, 78, 82, 84, 79, 80, 81, 78, 82, 78, 82, 77, 83, 78, 82, 79, 80, 81, 77, 76, 77, 78, 75, 76, 78, 74, 75, 75, 74, 75, 72, 73, 75, 77, 86, 63, 64, 69, 71, 73, 75, 77, 78, 81, 87, 62, 63, 65, 66, 69, 71, 73, 75, 77, 79, 80, 81, 87, 63, 64, 65, 66, 68, 69, 71, 73, 75, 77, 79, 81, 83, 84, 85, 86, 87, 64, 65, 66, 71, 73, 75, 77, 79, 70, 71, 73, 75, 77, 79, 64, 65, 66, 71, 73, 75, 77, 79, 63, 64, 65, 66, 68, 69, 71, 73, 75, 77, 79, 81, 83, 84, 85, 86, 87, 62, 63, 65, 66, 69, 71, 73, 75, 77, 79, 80, 81, 87, 63, 64, 69, 71, 73, 75, 77, 78, 81, 87, 72, 73, 75, 77, 86, 74, 75, 75, 74, 75, 75, 76, 78, 76, 77, 78, 77, 79, 80, 81, 78, 82, 77, 83, 78, 82, 78, 82, 79, 80, 81, 76, 78, 82, 84, 75, 85, 75, 85, 75, 78, 82, 85, 75, 76, 77, 83, 84, 85 };

    //11
    private int[] _11x = { 3, 3, 4, 4, 5, 5, 5, 5, 6, 6, 7, 7, 7, 7, 7, 8, 8, 8, 8, 8, 8, 8, 12, 12, 12, 12, 12, 12, 12, 13, 13, 13, 13, 13, 14, 14, 15, 15, 15, 15, 16, 16, 17, 17 };
    private int[] _11y = { 3, 5, 3, 8, 2, 7, 8, 9, 8, 10, 1, 6, 7, 10, 11, 2, 3, 4, 5, 6, 9, 10, 2, 3, 4, 5, 6, 9, 10, 1, 6, 7, 10, 11, 8, 10, 2, 7, 8, 9, 3, 8, 3, 5 };

    //12
    private int[] _12x = { 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10, 10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15, 15, 16, 16, 16, 17, 17, 17, 17, 18, 18, 18, 18, 18, 18, 18, 18, 19, 19, 19, 19, 23, 23, 23, 23, 23, 23, 23, 23, 23, 24, 24, 24, 25, 25, 26, 26, 26, 26, 26, 27, 27, 27, 28, 28, 28, 29, 29, 30, 30, 30, 31, 31, 32, 32, 33, 33, 34, 34, 34, 35, 35, 35, 35, 35, 36, 36, 36, 36, 37, 37, 37, 37, 38, 38, 38, 38, 39, 39, 39, 39, 39, 39, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 49, 50, 50, 51, 51, 52, 52, 53, 53, 54, 54, 55, 55, 56, 56, 57, 57, 58, 58, 59, 59, 60, 60, 61, 65, 66, 66, 67, 67, 67, 68, 68, 69, 69, 70, 70, 71, 71, 72, 72, 72, 73, 73, 73, 74, 74, 74, 75, 75, 75, 75, 76, 76, 77, 77, 78, 78, 78, 79, 79, 79, 79, 80, 80, 80, 80, 81, 81, 81, 81, 82, 82, 82, 83, 83, 83, 84, 84, 84, 84, 85, 85, 86, 86, 86, 87, 93, 93, 93, 93, 93, 93, 93, 93, 93, 93, 93, 93, 93, 93, 93, 93, 93, 93, 93, 93, 93, 93, 93, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94 };
    private int[] _12y = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 10, 21, 33, 10, 21, 33, 10, 21, 33, 10, 21, 33, 10, 21, 33, 10, 21, 33, 10, 21, 33, 10, 21, 33, 10, 20, 22, 32, 10, 19, 23, 31, 11, 18, 24, 30, 12, 17, 25, 26, 27, 28, 29, 13, 14, 15, 16, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 22, 24, 25, 26, 27, 22, 27, 28, 22, 29, 30, 22, 30, 22, 31, 32, 22, 33, 22, 33, 22, 32, 22, 30, 31, 22, 26, 27, 28, 29, 22, 23, 24, 25, 18, 19, 20, 21, 15, 16, 17, 18, 10, 11, 12, 13, 14, 15, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 22, 21, 23, 20, 24, 19, 25, 18, 26, 17, 27, 16, 28, 15, 29, 14, 30, 13, 31, 12, 32, 11, 33, 10, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 22, 23, 24, 22, 25, 26, 22, 27, 28, 22, 29, 30, 31, 22, 32, 22, 33, 22, 31, 32, 22, 28, 29, 30, 22, 28, 27, 28, 22, 23, 24, 25, 21, 22, 23, 18, 19, 20, 14, 15, 16, 17, 13, 14, 10, 11, 12, 10, 10, 11, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 10, 11, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33 };

    //13
    private int[] _13x = { 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 15, 15, 16, 16, 17, 18, 18, 19, 20, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 30, 31, 32, 32, 33, 34, 34, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 38, 38, 39, 39, 40, 40, 41, 41, 42, 42, 43, 43, 44, 44 };
    private int[] _13y = { 13, 14, 12, 13, 11, 12, 10, 11, 9, 10, 8, 9, 7, 8, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 6, 7, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 6, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 5, 6, 4, 5, 4, 3, 4, 3, 2, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 6, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 6, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 6, 7, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13, 14 };

    //14
    private int[] _14x = { 3, 3, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 6, 6, 7, 7, 8, 8, 9, 10, 11, 12, 13, 13, 14, 14, 15, 15, 16, 16, 16, 17, 17, 17, 18, 18, 18, 19, 19, 19, 20, 20, 21, 21 };
    private int[] _14y = { 7, 8, 6, 7, 5, 6, 12, 13, 14, 15, 16, 17, 18, 19, 20, 4, 5, 3, 4, 2, 3, 2, 2, 2, 2, 2, 16, 2, 16, 2, 16, 2, 3, 16, 3, 4, 16, 4, 5, 16, 5, 6, 16, 6, 7, 7, 8 };

    //15
    private int[] _15x = { 4, 5, 6, 7, 8, 9, 9, 9, 9, 9, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 42 };
    private int[] _15y = { 8, 8, 8, 8, 8, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 39, 40 };

    //16
    private int[] _16x = { 40, 40, 40, 41, 41, 42, 42, 42, 43, 44, 44, 44, 44 };
    private int[] _16y = { 58, 61, 62, 59, 62, 58, 59, 62, 60, 58, 59, 60, 62 };

    //17
    private int[] _17x = { 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 14, 14, 14, 15, 15, 15, 21, 21, 22, 22, 22, 22, 22, 22, 22, 22, 23, 23 };
    private int[] _17y = { 8, 13, 6, 7, 9, 10, 11, 12, 14, 15, 8, 13, 9, 10, 11, 8, 9, 10, 7, 12, 5, 6, 8, 9, 10, 11, 13, 14, 7, 12 };

    //18
    private int[] _18x = { 11, 11, 11, 12, 12, 14, 14, 15, 16, 16, 16, 17, 17, 17, 17, 17, 17, 17, 17, 17, 18, 18, 18, 18, 18, 19, 19, 19, 19, 19, 19, 19, 20, 20, 20, 20, 20, 20, 20, 20, 21, 21, 21, 21, 21, 21, 21, 22, 22, 22, 22, 22, 23, 23, 23, 23, 23, 23, 23, 23, 23, 24, 24, 24, 25, 26, 26, 28, 28, 29, 29, 29 };
    private int[] _18y = { 21, 22, 23, 21, 23, 20, 23, 23, 20, 22, 23, 11, 12, 14, 15, 16, 18, 19, 20, 21, 11, 16, 19, 21, 23, 11, 12, 17, 18, 20, 22, 23, 14, 16, 17, 19, 21, 23, 24, 26, 17, 18, 20, 22, 23, 28, 29, 17, 19, 21, 24, 29, 19, 20, 21, 22, 24, 25, 26, 28, 29, 17, 18, 20, 17, 17, 20, 17, 19, 17, 18, 19 };

    public int lvl;

    private GameObject gm;
    private GridGeneration gg;

    void Awake()
    {
       
        gm = GameObject.Find("GridGenerator");
        gg = gm.GetComponent<GridGeneration>();
        if(lvl == 1)
		{
            gg.SetX(_1x);
            gg.SetY(_1y);
        }
        if (lvl == 2)
        {
            gg.SetX(_2x);
            gg.SetY(_2y);
        }
        if (lvl == 3)
        {
            gg.SetX(_3x);
            gg.SetY(_3y);
        }
        if (lvl == 4)
        {
            gg.SetX(_4x);
            gg.SetY(_4y);
        }
        if (lvl == 5)
        {
            gg.SetX(_5x);
            gg.SetY(_5y);
        }
        if (lvl == 6)
        {
            gg.SetX(_6x);
            gg.SetY(_6y);
        }
        if (lvl == 7)
        {
            gg.SetX(_7x);
            gg.SetY(_7y);
        }
        if (lvl == 8)
        {
            gg.SetX(_8x);
            gg.SetY(_8y);
        }
        if (lvl == 9)
        {
            gg.SetX(_9x);
            gg.SetY(_9y);
        }
        if (lvl == 10)
        {
            gg.SetX(_10x);
            gg.SetY(_10y);
        }
        if (lvl == 11)
        {
            gg.SetX(_11x);
            gg.SetY(_11y);
        }
        if (lvl == 12)
        {
            gg.SetX(_12x);
            gg.SetY(_12y);
        }
        if (lvl == 13)
        {
            gg.SetX(_13x);
            gg.SetY(_13y);
        }
        if (lvl == 14)
        {
            gg.SetX(_14x);
            gg.SetY(_14y);
        }
        if (lvl == 15)
        {
            gg.SetX(_15x);
            gg.SetY(_15y);
        }
        if (lvl == 16)
        {
            gg.SetX(_16x);
            gg.SetY(_16y);
        }
        if (lvl == 17)
        {
            gg.SetX(_17x);
            gg.SetY(_17y);
        }
        if (lvl == 18)
        {
            gg.SetX(_18x);
            gg.SetY(_18y);
        }
    }
    
}
