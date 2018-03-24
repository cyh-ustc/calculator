#!/usr/bin/env python3
import math
pi = math.pi
e = math.e

	
def exp(x):
	return math.exp(x)
def log(x):
	return math.log10(x)
def ln(x):
	return math.log(x)
def fact(x):
	return math.factorial(x)
def sinh(x):
	return math.sinh(x)
def cosh(x):
	return math.cosh(x)
def tanh(x):
	return math.tanh(x)
def asinh(x):
	return math.asinh(x)
def acosh(x):
	return math.acosh(x)
def atanh(x):
	return math.atanh(x)

def calc(expr):
	expr = expr.replace('^', '**')
	z = open('ans.txt', 'w')
	try:

		z.write(str(eval(expr)))

	except:
		z.write('error')
		
	z.close()
f = open('expr.txt', 'r')
angle = int(f.readline())
if angle == 0:
	def sin(x):
		return math.sin(math.radians(x))
	def cos(x):
		return math.cos(math.radians(x))
	def tan(x):
		return math.cos(math.radians(x))
	def asin(x):
		return math.degrees((math.asin(x)))
	def acos(x):
		return math.degrees((math.acos(x)))
	def atan(x):
		return math.degrees((math.atan(x)))
elif angle == 1:
	def sin(x):
		return math.sin(x)
	def cos(x):
		return math.cos(x)
	def tan(x):
		return math.tan(x)
	def asin(x):
		return math.sin(x)
	def acos(x):
		return math.cos(x)
	def atan(x):
		return math.tan(x)
else:
	def sin(x):
		return math.sin(math.radians(x*0.9))
	def cos(x):
		return math.cos(math.radians(x*0.9))
	def tan(x):
		return math.cos(math.radians(x*0.9))	
	def asin(x):
		return math.degrees((math.asin(x)))/0.9
	def acos(x):
		return math.degrees((math.acos(x)))/0.9
	def atan(x):
		return math.degrees((math.atan(x)))/0.9
calc(f.readline())
f.close()