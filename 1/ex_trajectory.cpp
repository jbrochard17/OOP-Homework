#define _USE_MATH_DEFINES
#include <stdio.h>
#include <math.h>

float g = 9.81;

float convertRadian(float teta){
    return teta * M_PI / 180;
}

void decompose(float v, float teta, float* vx, float* vy){
    *vx = v * cos(teta);
    *vy = v * sin(teta);
}

float timeFlight(float vy){
    return 2 * vy / g;
}

float maxHeight(float vy){
    return pow(vy,2)/(2*g);
}

float horizontalRange(float vx, float t_flight){
    return vx * t_flight;
}

float verticalPos(float x, float teta, float v){
    return x * tan(teta) - g * pow(x,2)/(2 * pow(v,2) * pow(cos(teta),2));
}

void simulator(float v, float teta){
    v = fabs(v);
    float vx,vy;
    float x;
    teta = convertRadian(teta);
    printf("teta in rad : %f \n",teta);
    decompose(v, teta, &vx, &vy);
    printf("vx = %f \nvy = %f \n",vx, vy);
    float t_flight = timeFlight(vy);
    printf("time of flight : %fs \n",t_flight);
    float H_max = maxHeight(vy);
    printf("maximum height : %fm \n",H_max);
    float R = horizontalRange(vx,t_flight);
    printf("horizontal range : %fm \n",R);
    printf("Enter the horizontal distance (m) : ");
    scanf("%f", &x);
    float y = verticalPos(x, teta, v);
    printf("height at x = %fm : %fm \n",x, y);
    
}

int main()
{
    float v, teta;
    printf("Enter the initial velocity (m/s) and the angle of projection (degrees) : ");
    scanf("%f %f", &v, &teta);
    simulator(v,teta);
    return 0;
}