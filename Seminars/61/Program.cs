// Найти произведение двух матриц.

static double[][] MatrixProduct(double[][] matrixA,
  double[][] matrixB)
{
  int aRows = matrixA.Length; int aCols = matrixA[0].Length;
  int bRows = matrixB.Length; int bCols = matrixB[0].Length;
  if (aCols != bRows)
    throw new Exception("Non-conformable matrices in MatrixProduct");
  double[][] result = matrix (aRows, bCols);
  for (int i = 0; i < aRows; ++i) // каждая строка A
    for (int j = 0; j < bCols; ++j) // каждый столбец B
      for (int k = 0; k < aCols; ++k)
        result[i][j] += matrixA[i][k] * matrixB[k][j];
  return result;
}
