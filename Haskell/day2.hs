
doubleNum::Int->Int
doubleNum n = n*2

sumN::Integer->Integer
sumN 0=0
sumN n=n+sumN(n-1)

sumFact::Integer->Integer
sumFact 0=1
sumFact n=n*sumFact(n-1)

printNM :: Int -> Int -> IO()
printNM 0 m = putStr ""
printNM n m = do
 printNM (n-1) m
 if n == m 
 then
  putStrLn ((show n))
 else
  putStr ((show n) ++ ", ")

printN :: Int -> IO()
printN n = printNM n n

printTr :: Int -> IO()
printTr 0 = putStr ""
printTr n = do
  printTr (n-1)
  putStrLn (replicate n '*')

printRec :: Int -> Int-> Char -> IO()
printRec _ 0 _= putStr ""
printRec a b ch = do
  printRec a (b-1) ch
  putStrLn (replicate a ch)

printSqr :: Int -> IO()
printSqr a = printRec a a '$'


sumMy :: [Int] -> Int
sumMy [] = 0
sumMy (x:xs) = x + sumMy xs

productMy :: [Int] -> Int
productMy [] = 1
productMy (x:xs) = x * productMy xs

even :: Integer -> Bool
even x = (mod x 2) == 0 

mapMy :: (Int->Int) -> [Int] -> [Int]
mapMy func [] = []
mapMy func (x:xs) = (func x) : (mapMy func xs)

printMySum :: Integer -> Integer
printMySum 0 = 0
printMySum n = n + printMySum(n - 1) 

len :: [a]-> Int
len [] = 0
len (_:xs) = 1 + len xs

count :: (Ord a) => a -> [a] -> Int
count _ [] = 0
count num (x:xs)
  | num == x = 1 + count num xs
  | otherwise = count  num xs
--count 'l' "Hello"  and will return 2

triangle :: Float -> Float -> Float -> [Float]
triangle a b c = [a+b+c, a * b]

triangle :: Float -> Float -> Float -> [Float]
triangle a b c
 | a>0 && b>0 && c>0 && a<b+c && b<a+c && c<a+b = [per, s]
 | otherwise = [-1, -1]
 where
 per = a + b + c
 p = per/2
 s = sqrt (p*(p-a)*(p-b)*(p-c))
 
rect :: Float -> Float -> (Float, Float, [Char])
rect a b
 | a <= 0 || b <= 0 = (-1, -1, "invalid")
 | a == b           = (p, s, "square")
 | otherwise        = (p, s, "rectangle")
 where
 p = 2*(a+b)
 s = a*b
 

doubleNum x = 2*x

 
mapMy :: (a->b) -> [a] -> [b]
mapMy _ [] = []
mapMy f (x:xs) = f x : mapMy f xs
 
qSort :: (Ord a) => [a] -> [a]
qSort [] = []
qSort (x:xs) = qSort less ++ [x] ++ qSort more 
 where 
  less = (filter (<x) xs)
  more = (filter (>=x) xs)
 
qSort2 :: (Ord a) => [a] -> [a]
qSort2 [] = []
qSort2 (x:xs) = qSort2 [y | y <- xs, y < x] ++ [x] ++ qSort2 [y | y <- xs, y >= x]
 
primes :: [Int]
primes = filterPrime [2..]
  where filterPrime (p:xs) = p : filterPrime [x | x <- xs, x `mod` p /= 0

getOperation :: Int -> (Int->Int->Int)
getOperation 1 = \x y -> x + y
getOperation 2 = \x y -> x - y
getOperation 3 = \x y -> x * y
getOperation 4 = \x y -> x `div` y