printNums::Int->IO()
printNums 0 = putStr ""
printNums n = do
  print n
  printNums (n-1)