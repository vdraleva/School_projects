main :: IO()
main = do
 line1<-getLine
 line2<-getLine
 let n = read line1 :: Int
 let s = line2 !! 0
 printTr n s

 
printTr :: Int -> Char -> IO()
printTr 1 ch = putStr [ch]
printTr n ch = do
  putStrLn (replicate n ch)
  printTr (n-1) ch