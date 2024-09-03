//1.1
#include <stdio.h>
#include <stdlib.h>
int main (void)
{
int a, b = 5, c;
double x, y = -.5, z;
printf("a=");
scanf("%d", &a);
x = c = a;
printf("x = c = a : a=%d c=%d x=%f\n",a, c, x);
a += b;
printf("a += b : a=%d\n", a);
x *= b+a;
printf("x *= b+a : x=%lf\n", x);
b += a--;
printf("b += a-- : a=%d b=%d\n", a, b);
x -= ++c;
printf("x -= ++c : c=%d x=%lf\n", c, x);
c = a/b;
printf("c = a/b : c=%4d\n",c);
c = a%b;
printf("c = a%%b : c=%d\n",c);
y += (a+1)/a++;
printf("y += (a+1)/a++ : a=%d y=%.3lf\ty=%.0lf\n",
 a, y, y);
b = 3*(y-=.6)+2*b+1;
printf("b = 3*(y-=.6)+2*b+1 : b=%d y=%.1lf\n",
 b, y);
z = a/2;
printf("z = a/2 : z = a/2 : z=%lf\n", z);
z = (double)a/2;
printf("z = (double)a/2 : z=%lf\n", z);
y = (x = 5.7)/2;
printf("y = (x = 5.7)/2 : x=%lf y=%lf\n", x, y);
y = (int)x/2;
printf("y = (int)x/2 : y=%f\n", y);
z = (b-3)/2 - x/5 +(c/=2) + 1/4*z - y++ + ++b/3.;
printf("z = (b-3)/2 - x/5 +(c/=2) + 1/4*z - y++ \
+ ++b/3. :\n\a=%d b=%d c=%d x=%lf y=%lf z=%lf\n",
 a,b,c,x,y,z);
system("pause");
return 0;
}
