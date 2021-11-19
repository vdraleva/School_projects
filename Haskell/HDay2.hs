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