main :: IO()
main = do
  line1 <- getLine
  line2 <- getLine
  let n = read line1 :: Integer
  let m = read line2 :: Integer
  print (max (fib n) (fact m))


fact::Integer->Integer
fact 0=1
fact n=n*fact(n-1)

fib::Integer->Integer
fib 0=0
fib 1=1
fib n =fib(n-2)+fib(n-1)
