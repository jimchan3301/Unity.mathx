﻿#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions

#endregion

using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
    
    public static partial class mathx
    {
        /// Returns the sign of the given value.
        [MethodImpl(IL)] public static float4 sign(this float4 f) => math.sign(f);
        ///<inheritdoc cref="sign(Mathematics.float4)"/>
        [MethodImpl(IL)] public static float3 sign(this float3 f) => math.sign(f);
        ///<inheritdoc cref="sign(float4)"/>
        [MethodImpl(IL)] public static float2 sign(this float2 f) => math.sign(f);
        ///<inheritdoc cref="sign(float4)"/>
        [MethodImpl(IL)] public static float sign(this float f) => math.sign(f);
        ///<inheritdoc cref="sign(float4)"/>
        [MethodImpl(IL)] public static int sign(this int f) => (int)math.sign(f);
        ///<inheritdoc cref="sign(float4)"/>
        [MethodImpl(IL)] public static float4 sign(this Vector4 f) => math.sign(f);
        ///<inheritdoc cref="sign(float4)"/>
        [MethodImpl(IL)] public static float3 sign(this Vector3 f) => math.sign(f);
        ///<inheritdoc cref="sign(float4)"/>
        [MethodImpl(IL)] public static float2 sign(this Vector2 f) => math.sign(f);
        ///<inheritdoc cref="sign(float4)"/>
        [MethodImpl(IL)] public static double4 sign(this double4 f) => math.sign(f);
        ///<inheritdoc cref="sign(float4)"/>
        [MethodImpl(IL)] public static double3 sign(this double3 f) => math.sign(f);
        ///<inheritdoc cref="sign(float4)"/>
        [MethodImpl(IL)] public static double2 sign(this double2 f) => math.sign(f);
        ///<inheritdoc cref="sign(float4)"/>
        [MethodImpl(IL)] public static double sign(this double f) => math.sign(f);

        // Absolute Value ------------------------------------------------------------------------------
        /// The componentwise absolute value of the input.
        [MethodImpl(IL)] public static float4 abs(this float4 f) => math.abs(f);
        /// <inheritdoc cref="abs(float4)"/>
        [MethodImpl(IL)] public static float3 abs(this float3 f) => math.abs(f);
        /// <inheritdoc cref="abs(float4)"/>
        [MethodImpl(IL)] public static float2 abs(this float2 f) => math.abs(f);
        /// <inheritdoc cref="abs(float4)"/>
        [MethodImpl(IL)] public static float abs(this float f) => math.abs(f);
        /// <inheritdoc cref="abs(float4)"/>
        [MethodImpl(IL)] public static int abs(this int f) => math.abs(f);
        /// <inheritdoc cref="abs(float4)"/>
        [MethodImpl(IL)] public static float4 abs(this Vector4 f) => math.abs(f);
        /// <inheritdoc cref="abs(float4)"/>
        [MethodImpl(IL)] public static float3 abs(this Vector3 f) => math.abs(f);
        /// <inheritdoc cref="abs(float4)"/>
        [MethodImpl(IL)] public static float2 abs(this Vector2 f) => math.abs(f);
        /// <inheritdoc cref="abs(float4)"/>
        [MethodImpl(IL)] public static double4 abs(this double4 f) => math.abs(f);
        /// <inheritdoc cref="abs(float4)"/>
        [MethodImpl(IL)] public static double3 abs(this double3 f) => math.abs(f);
        /// <inheritdoc cref="abs(float4)"/>
        [MethodImpl(IL)] public static double2 abs(this double2 f) => math.abs(f);
        /// <inheritdoc cref="abs(float4)"/>
        [MethodImpl(IL)] public static double abs(this double f) => math.abs(f);

        #region csum

        /// Returns the sum of all components of the vector
        [MethodImpl(IL)] public static float sum(this float4 f) => math.csum(f);
        /// <inheritdoc cref="sum(float4)"/> 
        [MethodImpl(IL)] public static float sum(this float3 f) => math.csum(f);
        /// <inheritdoc cref="sum(float4)"/> 
        [MethodImpl(IL)] public static float sum(this float2 f) => math.csum(f);
        /// <inheritdoc cref="sum(float4)"/> 
        [MethodImpl(IL)] public static float sum(this Vector4 f) => math.csum(f);
        /// <inheritdoc cref="sum(float4)"/> 
        [MethodImpl(IL)] public static float sum(this Vector3 f) => math.csum(f);
        /// <inheritdoc cref="sum(float4)"/> 
        [MethodImpl(IL)] public static float sum(this Vector2 f) => math.csum(f);
        /// <inheritdoc cref="sum(float4)"/> 
        [MethodImpl(IL)] public static int sum(this int4 f) => math.csum(f);
        /// <inheritdoc cref="sum(float4)"/> 
        [MethodImpl(IL)] public static int sum(this int3 f) => math.csum(f);
        /// <inheritdoc cref="sum(float4)"/> 
        [MethodImpl(IL)] public static int sum(this int2 f) => math.csum(f);
        /// <inheritdoc cref="sum(float4)"/> 
        [MethodImpl(IL)] public static double sum(this double4 f) => math.csum(f);
        /// <inheritdoc cref="sum(float4)"/> 
        [MethodImpl(IL)] public static double sum(this double3 f) => math.csum(f);
        /// <inheritdoc cref="sum(float4)"/> 
        [MethodImpl(IL)] public static double sum(this double2 f) => math.csum(f);

        #endregion

        #region cmul

        /// Returns the product of all components of the vector
        [MethodImpl(IL)] public static float cmul(this float4 f) => f.x * f.y * f.z * f.w;
        /// <inheritdoc cref="cmul(float4)"/>
        [MethodImpl(IL)] public static float cmul(this float3 f) => f.x * f.y * f.z;
        /// <inheritdoc cref="cmul(float4)"/>
        [MethodImpl(IL)] public static float cmul(this float2 f) => f.x * f.y;
        /// <inheritdoc cref="cmul(float4)"/>
        [MethodImpl(IL)] public static float cmul(this Vector4 f) => f.x * f.y * f.z * f.w;
        /// <inheritdoc cref="cmul(float4)"/>
        [MethodImpl(IL)] public static float cmul(this Vector3 f) => f.x * f.y * f.z;
        /// <inheritdoc cref="cmul(float4)"/>
        [MethodImpl(IL)] public static float cmul(this Vector2 f) => f.x * f.y;
        /// <inheritdoc cref="cmul(float4)"/>
        [MethodImpl(IL)] public static int cmul(this int4 f) => f.x * f.y * f.z * f.w;
        /// <inheritdoc cref="cmul(float4)"/>
        [MethodImpl(IL)] public static int cmul(this int3 f) => f.x * f.y * f.z;
        /// <inheritdoc cref="cmul(float4)"/>
        [MethodImpl(IL)] public static int cmul(this int2 f) => f.x * f.y;
        /// <inheritdoc cref="cmul(float4)"/>
        [MethodImpl(IL)] public static double cmul(this double4 f) => f.x * f.y * f.z * f.w;
        /// <inheritdoc cref="cmul(float4)"/>
        [MethodImpl(IL)] public static double cmul(this double3 f) => f.x * f.y * f.z;
        /// <inheritdoc cref="cmul(float4)"/>
        [MethodImpl(IL)] public static double cmul(this double2 f) => f.x * f.y;

        #endregion

        #region inv

        /// Returns one minus the given value. => ex : color inversion
        [MethodImpl(IL)] public static float4 inv(this float4 f) => 1 - f;
        /// <inheritdoc cref="inv(float4)"/>
        [MethodImpl(IL)] public static float3 inv(this float3 f) => 1 - f;
        /// <inheritdoc cref="inv(float4)"/>
        [MethodImpl(IL)] public static float2 inv(this float2 f) => 1 - f;
        /// <inheritdoc cref="inv(float4)"/>
        [MethodImpl(IL)] public static float inv(this float f) => 1 - f;
        /// <inheritdoc cref="inv(float4)"/>
        [MethodImpl(IL)] public static int inv(this int f) => 1 - f;
        /// <inheritdoc cref="inv(float4)"/>
        [MethodImpl(IL)] public static double4 inv(this double4 f) => 1 - f;
        /// <inheritdoc cref="inv(float4)"/>
        [MethodImpl(IL)] public static double3 inv(this double3 f) => 1 - f;
        /// <inheritdoc cref="inv(float4)"/>
        [MethodImpl(IL)] public static double2 inv(this double2 f) => 1 - f;
        /// <inheritdoc cref="inv(float4)"/>
        [MethodImpl(IL)] public static double inv(this double f) => 1 - f;
        /// <inheritdoc cref="inv(float4)"/>
        [MethodImpl(IL)] public static float4 inv(this Vector4 f) => 1 - f.asfloat();
        /// <inheritdoc cref="inv(float4)"/>
        [MethodImpl(IL)] public static float3 inv(this Vector3 f) => 1 - f.asfloat();
        /// <inheritdoc cref="inv(float4)"/>
        [MethodImpl(IL)] public static float2 inv(this Vector2 f) => 1 - f.asfloat();

        #endregion

        #region neg

        /// Returns the negation of the given value.
        [MethodImpl(IL)] public static float4 neg(this float4 f) => -f;
        /// <inheritdoc cref="neg(float4)"/>
        [MethodImpl(IL)] public static float3 neg(this float3 f) => -f;
        /// <inheritdoc cref="neg(float4)"/>
        [MethodImpl(IL)] public static float2 neg(this float2 f) => -f;
        /// <inheritdoc cref="neg(float4)"/>
        [MethodImpl(IL)] public static float neg(this float f) => -f;
        /// <inheritdoc cref="neg(float4)"/>
        [MethodImpl(IL)] public static int neg(this int f) => -f;
        /// <inheritdoc cref="neg(float4)"/>
        [MethodImpl(IL)] public static double4 neg(this double4 f) => -f;
        /// <inheritdoc cref="neg(float4)"/>
        [MethodImpl(IL)] public static double3 neg(this double3 f) => -f;
        /// <inheritdoc cref="neg(float4)"/>
        [MethodImpl(IL)] public static double2 neg(this double2 f) => -f;
        /// <inheritdoc cref="neg(float4)"/>
        [MethodImpl(IL)] public static double neg(this double f) => -f;
        /// <inheritdoc cref="neg(float4)"/>
        [MethodImpl(IL)] public static float4 neg(this Vector4 f) => -f;
        /// <inheritdoc cref="neg(float4)"/>
        [MethodImpl(IL)] public static float3 neg(this Vector3 f) => -f;
        /// <inheritdoc cref="neg(float4)"/>
        [MethodImpl(IL)] public static float2 neg(this Vector2 f) => -f;
        #endregion


        #region rcp

        /// Returns the componentwise reciprocal a vector.
        [MethodImpl(IL)] public static float4 rcp(this float4 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(float4)"/>
        [MethodImpl(IL)] public static float3 rcp(this float3 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(float4)"/>
        [MethodImpl(IL)] public static float2 rcp(this float2 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(float4)"/>
        [MethodImpl(IL)] public static float rcp(this float f) => math.rcp(f);
        /// <inheritdoc cref="rcp(float4)"/>
        [MethodImpl(IL)] public static float rcp(this int f) => math.rcp(f);
        /// <inheritdoc cref="rcp(float4)"/>
        [MethodImpl(IL)] public static float4 rcp(this Vector4 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(float4)"/>
        [MethodImpl(IL)] public static float3 rcp(this Vector3 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(float4)"/>
        [MethodImpl(IL)] public static float2 rcp(this Vector2 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(float4)"/>
        [MethodImpl(IL)] public static double4 rcp(this double4 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(float4)"/>
        [MethodImpl(IL)] public static double3 rcp(this double3 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(float4)"/>
        [MethodImpl(IL)] public static double2 rcp(this double2 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(float4)"/>
        [MethodImpl(IL)] public static double rcp(this double f) => math.rcp(f);
        
        #endregion

        #region pow

        /// <summary>Returns the componentwise result of raising x to the power y.</summary>
        public static float4 pow(this float4 f, float4 pow) => math.pow(f, pow);
        /// <inheritdoc cref="pow(float4, float4)"/>
        [MethodImpl(IL)] public static float3 pow(this float3 f, float3 pow) => math.pow(f, pow);
        /// <inheritdoc cref="pow(float4, float4)"/>
        [MethodImpl(IL)] public static float2 pow(this float2 f, float2 pow) => math.pow(f, pow);
        /// <inheritdoc cref="pow(float4, float4)"/>
        [MethodImpl(IL)] public static float pow(this float f, float pow) => math.pow(f, pow);
        /// <inheritdoc cref="pow(float4, float4)"/>
        [MethodImpl(IL)] public static float pow(this int f, float pow) => math.pow(f, pow);
        /// <inheritdoc cref="pow(float4, float4)"/>
        [MethodImpl(IL)] public static int pow(this int f, int pow) => (int)math.pow(f, pow);
        /// <inheritdoc cref="pow(float4, float4)"/>
        [MethodImpl(IL)] public static float4 pow(this Vector4 f, float4 pow) => math.pow(f, pow);
        /// <inheritdoc cref="pow(float4, float4)"/>
        [MethodImpl(IL)] public static float3 pow(this Vector3 f, float3 pow) => math.pow(f, pow);
        /// <inheritdoc cref="pow(float4, float4)"/>
        [MethodImpl(IL)] public static float2 pow(this Vector2 f, float2 pow) => math.pow(f, pow);
        /// <inheritdoc cref="pow(float4, float4)"/>
        [MethodImpl(IL)] public static double4 pow(this double4 f, double4 min) => math.pow(f, min);
        /// <inheritdoc cref="pow(float4, float4)"/>
        [MethodImpl(IL)] public static double3 pow(this double3 f, double3 min) => math.pow(f, min);
        /// <inheritdoc cref="pow(float4, float4)"/>
        [MethodImpl(IL)] public static double2 pow(this double2 f, double2 min) => math.pow(f, min);
        /// <inheritdoc cref="pow(float4, float4)"/>
        [MethodImpl(IL)] public static double pow(this double f, double min) => math.pow(f, min);

        #endregion

        #region sq

        /// Returns x^2
        [MethodImpl(IL)] public static float4 sq(this float4 f) => f * f;
        /// <inheritdoc cref="sq(float4)"/>
        [MethodImpl(IL)] public static float3 sq(this float3 f) => f * f;
        /// <inheritdoc cref="sq(float4)"/>
        [MethodImpl(IL)] public static float2 sq(this float2 f) => f * f;
        /// <inheritdoc cref="sq(float4)"/>
        [MethodImpl(IL)] public static float sq(this float f) => f * f;
        /// <inheritdoc cref="sq(float4)"/>
        [MethodImpl(IL)] public static int sq(this int f) => f * f;
        /// <inheritdoc cref="sq(float4)"/>
        [MethodImpl(IL)] public static float4 sq(this Vector4 f) => f.cast() * f;
        /// <inheritdoc cref="sq(float4)"/>
        [MethodImpl(IL)] public static float3 sq(this Vector3 f) => f.cast() * f;
        /// <inheritdoc cref="sq(float4)"/>
        [MethodImpl(IL)] public static float2 sq(this Vector2 f) => f * f;
        /// <inheritdoc cref="sq(float4)"/>
        [MethodImpl(IL)] public static double4 sq(this double4 f) => f * f;
        /// <inheritdoc cref="sq(float4)"/>
        [MethodImpl(IL)] public static double3 sq(this double3 f) => f * f;
        /// <inheritdoc cref="sq(float4)"/>
        [MethodImpl(IL)] public static double2 sq(this double2 f) => f * f;
        /// <inheritdoc cref="sq(float4)"/>
        [MethodImpl(IL)] public static double sq(this double f) => f * f;

        #endregion

        #region cube

        /// <summary> Returns x^3 </summary>
        public static float4 cube(this float4 f) => f * f * f;
        /// <inheritdoc cref="cube(float4)"/>
        [MethodImpl(IL)] public static float3 cube(this float3 f) => f * f * f;
        /// <inheritdoc cref="cube(float4)"/>
        [MethodImpl(IL)] public static float2 cube(this float2 f) => f * f * f;
        /// <inheritdoc cref="cube(float4)"/>
        [MethodImpl(IL)] public static float cube(this float f) => f * f * f;
        /// <inheritdoc cref="cube(float4)"/>
        [MethodImpl(IL)] public static int cube(this int f) => f * f * f;
        /// <inheritdoc cref="cube(float4)"/>
        [MethodImpl(IL)] public static float4 cube(this Vector4 f) => f.cast().cube();
        /// <inheritdoc cref="cube(float4)"/>
        [MethodImpl(IL)] public static float3 cube(this Vector3 f) => f.cast().cube();
        /// <inheritdoc cref="cube(float4)"/>
        [MethodImpl(IL)] public static float2 cube(this Vector2 f) => f.cast().cube();
        /// <inheritdoc cref="cube(float4)"/>
        [MethodImpl(IL)] public static double4 cube(this double4 f) => f * f * f;
        /// <inheritdoc cref="cube(float4)"/>
        [MethodImpl(IL)] public static double3 cube(this double3 f) => f * f * f;
        /// <inheritdoc cref="cube(float4)"/>
        [MethodImpl(IL)] public static double2 cube(this double2 f) => f * f * f;
        /// <inheritdoc cref="cube(float4)"/>
        [MethodImpl(IL)] public static double cube(this double f) => f * f * f;

        #endregion

        #region pow4

        /// <summary> Returns x^4 </summary>
        public static float4 pow4(this float4 f) => f.sq().sq();
        /// <inheritdoc cref="pow4(float4)"/>
        [MethodImpl(IL)] public static float3 pow4(this float3 f) => f.sq().sq();
        /// <inheritdoc cref="pow4(float4)"/>
        [MethodImpl(IL)] public static float2 pow4(this float2 f) => f.sq().sq();
        /// <inheritdoc cref="pow4(float4)"/>
        [MethodImpl(IL)] public static float pow4(this float f) => f.sq().sq();
        /// <inheritdoc cref="pow4(float4)"/>
        [MethodImpl(IL)] public static int pow4(this int f) => f.sq().sq();
        /// <inheritdoc cref="pow4(float4)"/>
        [MethodImpl(IL)] public static float4 pow4(this Vector4 f) => f.cast().pow4();
        /// <inheritdoc cref="pow4(float4)"/>
        [MethodImpl(IL)] public static float3 pow4(this Vector3 f) => f.cast().pow4();
        /// <inheritdoc cref="pow4(float4)"/>
        [MethodImpl(IL)] public static float2 pow4(this Vector2 f) => f.cast().pow4();
        /// <inheritdoc cref="pow4(float4)"/>
        [MethodImpl(IL)] public static double4 pow4(this double4 f) => f.sq().sq();
        /// <inheritdoc cref="pow4(float4)"/>
        [MethodImpl(IL)] public static double3 pow4(this double3 f) => f.sq().sq();
        /// <inheritdoc cref="pow4(float4)"/>
        [MethodImpl(IL)] public static double2 pow4(this double2 f) => f.sq().sq();
        /// <inheritdoc cref="pow4(float4)"/>
        [MethodImpl(IL)] public static double pow4(this double f) => f.sq().sq();

        #endregion

        #region pow5

        /// <summary> Returns x^5 </summary>
        public static float4 pow5(this float4 f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(float4)" />
        [MethodImpl(IL)] public static float3 pow5(this float3 f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(float4)" />
        [MethodImpl(IL)] public static float2 pow5(this float2 f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(float4)" />
        [MethodImpl(IL)] public static float pow5(this float f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(float4)" />
        [MethodImpl(IL)] public static int pow5(this int f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(float4)" />
        [MethodImpl(IL)] public static float4 pow5(this Vector4 f) => f.cast().pow5();
        /// <inheritdoc cref="pow5(float4)" />
        [MethodImpl(IL)] public static float3 pow5(this Vector3 f) => f.cast().pow5();
        /// <inheritdoc cref="pow5(float4)" />
        [MethodImpl(IL)] public static float2 pow5(this Vector2 f) => f.cast().pow5();
        /// <inheritdoc cref="pow5(float4)" />
        [MethodImpl(IL)] public static double4 pow5(this double4 f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(float4)" />
        [MethodImpl(IL)] public static double3 pow5(this double3 f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(float4)" />
        [MethodImpl(IL)] public static double2 pow5(this double2 f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(float4)" />
        [MethodImpl(IL)] public static double pow5(this double f) => f.sq().sq() * f;

        #endregion



        #region dim

        /// Scales a vector by a scalar.
        [MethodImpl(IL)] public static float dim(this float a, float b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this float2 a, float2 b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this float3 a, float3 b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this float4 a, float4 b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this float2 a, float b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this float3 a, float b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this float4 a, float b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double dim(this double a, double b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double2 dim(this double2 a, double2 b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double3 dim(this double3 a, double3 b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double4 dim(this double4 a, double4 b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double2 dim(this double2 a, double b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double3 dim(this double3 a, double b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double4 dim(this double4 a, double b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int dim(this int a, int b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int2 dim(this int2 a, int2 b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int3 dim(this int3 a, int3 b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int4 dim(this int4 a, int4 b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int2 dim(this int2 a, int b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int3 dim(this int3 a, int b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int4 dim(this int4 a, int b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float dim(this int a, float b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this int2 a, float2 b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this int3 a, float3 b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this int4 a, float4 b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this int2 a, float b) => (float2)a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this int3 a, float b) => (float3)a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this int4 a, float b) => (float4)a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float dim (this float a, int b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this float2 a, int2 b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this float3 a, int3 b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this float4 a, int4 b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this float2 a, int b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this float3 a, int b) => a * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this float4 a, int b) => a * b;
        [MethodImpl(IL)] public static float2 dim(this float a, float2 b) => b * a;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this float a, float3 b) => b * a;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this float a, float4 b) => b * a;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this int a, float2 b) => b * a;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this int a, float3 b) => b * a;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this int a, float4 b) => b * a;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double2 dim(this double a, double2 b) => b * a;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double3 dim(this double a, double3 b) => b * a;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double4 dim(this double a, double4 b) => b * a;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double2 dim(this int a, double2 b) => b * a;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double3 dim(this int a, double3 b) => b * a;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double4 dim(this int a, double4 b) => b * a;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double2 dim(this double a, int2 b) => new(a * b.x, a * b.y);
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double3 dim(this double a, int3 b) => new(a * b.x, a * b.y, a * b.z);
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double4 dim(this double a, int4 b) => new(a * b.x, a * b.y, a * b.z, a * b.w);
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this float a, int2 b) => new(a * b.x, a * b.y);
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this float a, int3 b) => new(a * b.x, a * b.y, a * b.z);
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this float a, int4 b) => new(a * b.x, a * b.y, a * b.z, a * b.w);
        
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float dim(this float a, bool b) => a * b.asint();
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this float2 a, bool2 b) => a * b.asint();
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this float3 a, bool3 b) => a * b.asint();
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this float4 a, bool4 b) => a * b.asint();
        
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this float2 a, bool b) => a * b.asint();
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this float3 a, bool b) => a * b.asint();
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this float4 a, bool b) => a * b.asint();
        
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float dim(this bool a, float b) => b.asint() * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this bool2 a, float2 b) => a.asfloat() * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this bool3 a, float3 b) => a.asfloat() * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this bool4 a, float4 b) => a.asfloat() * b;
        
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this bool a, float2 b) => a.asint() * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this bool a, float3 b) => a.asint() * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this bool a, float4 b) => a.asint() * b;
        
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int dim(this bool a, int b) => a.asint() * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int2 dim(this bool2 a, int2 b) => a.asint() * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int3 dim(this bool3 a, int3 b) => a.asint() * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int4 dim(this bool4 a, int4 b) => a.asint() * b;
        
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int2 dim(this bool a, int2 b) => a.asint() * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int3 dim(this bool a, int3 b) => a.asint() * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int4 dim(this bool a, int4 b) => a.asint() * b;
        
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int dim(this int a, bool b) => a * b.asint();
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int2 dim(this int2 a, bool2 b) => a * b.asint();
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int3 dim(this int3 a, bool3 b) => a * b.asint();
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int4 dim(this int4 a, bool4 b) => a * b.asint();
        
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int2 dim(this int2 a, bool b) => a * b.asint();
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int3 dim(this int3 a, bool b) => a * b.asint();
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int4 dim(this int4 a, bool b) => a * b.asint();
        
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint dim(this bool a, uint b) => a.asuint() * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint2 dim(this bool2 a, uint2 b) => a.asuint() * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint3 dim(this bool3 a, uint3 b) => a.asuint() * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint4 dim(this bool4 a, uint4 b) => a.asuint() * b;
        
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint2 dim(this bool a, uint2 b) => a.asuint() * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint3 dim(this bool a, uint3 b) => a.asuint() * b;
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint4 dim(this bool a, uint4 b) => a.asuint() * b;
        
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint dim(this uint a, bool b) => a * b.asuint();
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint2 dim(this uint2 a, bool2 b) => a * b.asuint();
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint3 dim(this uint3 a, bool3 b) => a * b.asuint();
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint4 dim(this uint4 a, bool4 b) => a * b.asuint();
        
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint2 dim(this uint2 a, bool b) => a * b.asuint();
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint3 dim(this uint3 a, bool b) => a * b.asuint();
        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint4 dim(this uint4 a, bool b) => a * b.asuint();

        #endregion

        /// Returns input * 2 - 1
        /// Effectively remaps the range [0, 1] to [-1, 1]
        [MethodImpl(IL)] public static float m2n1(this float f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float2 m2n1(this float2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float3 m2n1(this float3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float4 m2n1(this float4 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static int m2n1(this int f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static int2 m2n1(this int2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static int3 m2n1(this int3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static int4 m2n1(this int4 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static double m2n1(this double f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static double2 m2n1(this double2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static double3 m2n1(this double3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static double4 m2n1(this double4 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float2x2 m2n1(this float2x2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float2x3 m2n1(this float2x3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float2x4 m2n1(this float2x4 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float3x2 m2n1(this float3x2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float3x3 m2n1(this float3x3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float3x4 m2n1(this float3x4 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float4x2 m2n1(this float4x2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float4x3 m2n1(this float4x3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float4x4 m2n1(this float4x4 f) => f * 2 - 1;
        
        /// Addition Operation
        [MethodImpl(IL)]
        public static float add(this float x, float y) => x + y;
        /// <inheritdoc cref="add(float, float)"/>
        [MethodImpl(IL)] public static float2 add(this float2 x, float2 y) => x + y;
        /// <inheritdoc cref="add(float, float)"/>
        [MethodImpl(IL)] public static float3 add(this float3 x, float3 y) => x + y;
        /// <inheritdoc cref="add(float, float)"/>
        [MethodImpl(IL)] public static float4 add(this float4 x, float4 y) => x + y;
        /// <inheritdoc cref="add(float, float)"/>
        [MethodImpl(IL)] public static float2 add(this float2 x, float y) => x + y;
        /// <inheritdoc cref="add(float, float)"/>
        [MethodImpl(IL)] public static float3 add(this float3 x, float y) => x + y;
        /// <inheritdoc cref="add(float, float)"/>
        [MethodImpl(IL)] public static float4 add(this float4 x, float y) => x + y;
        /// <inheritdoc cref="add(float, float)"/>
        [MethodImpl(IL)] public static float2 add(this float x, float2 y) => x + y;
        /// <inheritdoc cref="add(float, float)"/>
        [MethodImpl(IL)] public static float3 add(this float x, float3 y) => x + y;
        /// <inheritdoc cref="add(float, float)"/>
        [MethodImpl(IL)] public static float4 add(this float x, float4 y) => x + y;

        /// Subtraction Operation
        [MethodImpl(IL)] public static float sub(this float x, float y) => x - y;
        /// <inheritdoc cref="sub(float, float)"/>
        [MethodImpl(IL)] public static float2 sub(this float2 x, float2 y) => x - y;
        /// <inheritdoc cref="sub(float, float)"/>
        [MethodImpl(IL)] public static float3 sub(this float3 x, float3 y) => x - y;
        /// <inheritdoc cref="sub(float, float)"/>
        [MethodImpl(IL)] public static float4 sub(this float4 x, float4 y) => x - y;
        /// <inheritdoc cref="sub(float, float)"/>
        [MethodImpl(IL)] public static float2 sub(this float2 x, float y) => x - y;
        /// <inheritdoc cref="sub(float, float)"/>
        [MethodImpl(IL)] public static float3 sub(this float3 x, float y) => x - y;
        /// <inheritdoc cref="sub(float, float)"/>
        [MethodImpl(IL)] public static float4 sub(this float4 x, float y) => x - y;
        /// <inheritdoc cref="sub(float, float)"/>
        [MethodImpl(IL)] public static float2 sub(this float x, float2 y) => x - y;
        /// <inheritdoc cref="sub(float, float)"/>
        [MethodImpl(IL)] public static float3 sub(this float x, float3 y) => x - y;
        /// <inheritdoc cref="sub(float, float)"/>
        [MethodImpl(IL)] public static float4 sub(this float x, float4 y) => x - y;
        
        /// Division Operation
        [MethodImpl(IL)] public static float div(this float x, float y) => x / y;
        /// <inheritdoc cref="div(float, float)"/>
        [MethodImpl(IL)] public static float2 div(this float2 x, float2 y) => x / y;
        /// <inheritdoc cref="div(float, float)"/>
        [MethodImpl(IL)] public static float3 div(this float3 x, float3 y) => x / y;
        /// <inheritdoc cref="div(float, float)"/>
        [MethodImpl(IL)] public static float4 div(this float4 x, float4 y) => x / y;
        /// <inheritdoc cref="div(float, float)"/>
        [MethodImpl(IL)] public static float2 div(this float2 x, float y) => x / y;
        /// <inheritdoc cref="div(float, float)"/>
        [MethodImpl(IL)] public static float3 div(this float3 x, float y) => x / y;
        /// <inheritdoc cref="div(float, float)"/>
        [MethodImpl(IL)] public static float4 div(this float4 x, float y) => x / y;
        /// <inheritdoc cref="div(float, float)"/>
        [MethodImpl(IL)] public static float2 div(this float x, float2 y) => x / y;
        /// <inheritdoc cref="div(float, float)"/>
        [MethodImpl(IL)] public static float3 div(this float x, float3 y) => x / y;
        /// <inheritdoc cref="div(float, float)"/>
        [MethodImpl(IL)] public static float4 div(this float x, float4 y) => x / y;
        
        /// Shuffle Components
        [MethodImpl(IL)] public static float2 shuffle(this float2 f) => new(f.y, f.x);
        /// <inheritdoc cref="shuffle(Mathematics.float2)"/>
        [MethodImpl(IL)] public static float3 shuffle(this float3 f) => new(f.y, f.z, f.x);
        /// <inheritdoc cref="shuffle(Mathematics.float2)"/>
        [MethodImpl(IL)] public static float4 shuffle(this float4 f) => new(f.y, f.z, f.w, f.x);
        
        /// sets the value of x to f and returns f
        [MethodImpl(IL)] public static T set<T>(this T f, out T x) { x = f; return f; }

        #region Type Building

        ///<inheritdoc cref="math.float4(float)"/>
        public static float4 float4(float f) => math.float4(f);
        /// Returns a float4 with the first two components set to f, and the last two set to 0
        public static float4 float4(float2 f) => math.float4(f, 0, 0);
        /// Returns a float4 with the first three components set to f, and the last one set to 0
        public static float4 float4(float3 f) => math.float4(f, 0);
        /// <inheritdoc cref="math.float4(float, float, float, float)"/>
        public static float4 float4(float a, float b, float c, float d) => math.float4(a, b, c, d);
        /// <inheritdoc cref="math.float4(Mathematics.float2, Mathematics.float2)"/>
        public static float4 float4(float2 a, float2 b) => math.float4(a, b);
        /// <inheritdoc cref="math.float4(Mathematics.float3, float)"/>
        public static float4 float4(float3 a, float b) => math.float4(a, b);
        /// <inheritdoc cref="math.float4(float, Mathematics.float3)"/>
        public static float4 float4(float a, float3 b) => math.float4(a, b);
        /// <inheritdoc cref="math.float4(float, float, Mathematics.float2)"/>
        public static float4 float4(float a, float2 b, float c) => math.float4(a, b, c);
        /// <inheritdoc cref="math.float4(float, float, float, float)"/>
        public static float4 float4(float a, float b, float2 c) => math.float4(a, b, c);
        /// <inheritdoc cref="math.float4(float, float, float, float)"/>
        public static float4 float4(float2 a, float b, float c) => math.float4(a, b, c);
        
        /// <inheritdoc cref="math.float3(float, float, float)"/>
        public static float3 float3(float a, float b, float c) => math.float3(a, b, c);
        /// <inheritdoc cref="math.float3(Mathematics.float2, float)"/>
        public static float3 float3(float2 a, float b) => math.float3(a, b);
        /// <inheritdoc cref="math.float3(float, Mathematics.float2)"/>
        public static float3 float3(float a, float2 b) => math.float3(a, b);
        /// <inheritdoc cref="math.float3(float)"/>
        public static float3 float3(float f) => math.float3(f);
        /// <inheritdoc cref="math.float3(Mathematics.float2)"/>
        public static float3 float3(float2 f) => math.float3(f, 0);
        /// Returns a float3 with containing the first three components of a float4
        public static float3 float3(float4 f) => math.float3(f.xyz); // crop w
        
        /// <inheritdoc cref="math.float2(float, float)"/>
        public static float2 float2(float a, float b) => math.float2(a, b);
        /// <inheritdoc cref="math.float2(float)"/>
        public static float2 float2(float f) => math.float2(f);
        /// Returns a float2 with containing the first two components of a float3
        public static float2 float2(float3 f) => math.float2(f.xy); // crop z
        /// Returns a float2 with containing the first two components of a float4
        public static float2 float2(float4 f) => math.float2(f.xy); // crop zw


        #endregion





    }
}