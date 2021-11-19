DoubleNum :: Integer -> Integer
DoubleNum x = (2 * x)

sumMy::Int->Int->Int
sumMy a b=a+b

maxMy::Int->Int->Int
maxMy num1 num2=if num1>num2 then num1 else num2

maxMyTwo::Integer->Integer->Integer
maxMyTwo a b
 |a>b=a
 |otherwise=b

oddMy::Integer->Bool
oddMy n = (mod n 2) /=0

evenMy:: Integer->Bool
evenMy n=not(oddMy n)

isUpper::Char->Bool
isUpper ch=(ch>='A')&&(ch<='Z')

isLower::Char->Bool
isLower ch=(ch>='a')&&(ch<='z')

sumN::Integer->Integer
sumN 0=0
sumN n=n+sumN(n-1)

fact::Integer->Integer
fact 0=1
fact n=n*fact(n-1)

fib::Integer->Integer
fib 0=0
fib 1=1
fib n =fib(n-2)+fib(n-1)

fib2::Integer->Integer
 |n==0=0
 |n==1=1
 |otherwise n =fib(n-2)+fib(n-1)

day::Int->string
day 1="Monday"
day 2="Tuesday"
day 3="Wednesday"
day_="not availiable"

if'::Bool->Int->Int->Int
if' true a b = a
if' false a b = b