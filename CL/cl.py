Python 3.5.2 (v3.5.2:4def2a2901a5, Jun 25 2016, 22:01:18) [MSC v.1900 32 bit (Intel)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> x=13*11
>>> x2=(23**2-1)/(23-1)*x
>>> x2
3432.0
>>> x
143
>>> l = []
>>> m = 11
>>> c=13
>>> b=22
>>> a=23
>>> for n in range(1, 7):
	l.append(((a**n-1)/(a-1))*c%m)

	
>>> l
[2.0, 4.0, 6.0, 8.0, 10.0, 1.0]
>>> l = []
>>> for n in range(1, 20):
	l.append(((a**n-1)/(a-1))*c%m)

	
>>> l
[2.0, 4.0, 6.0, 8.0, 10.0, 1.0, 3.0, 5.0, 7.0, 9.0, 0.0, 2.0, 7.0, 4.0, 6.0, 7.0, 0.0, 9.0, 2.0]
>>> l = []
>>> d = 22
>>> x0 = 0
>>> l.append(x0)
>>> l
[0]
>>> for n in range(1, 20):
	l.append((d*l[len(l)-1]**2 + a*l[len(l)-1] + c)%m+1)

	
>>> l
[0, 3, 6, 9, 1, 4, 7, 10, 2, 5, 8, 11, 3, 6, 9, 1, 4, 7, 10, 2]
>>> 
