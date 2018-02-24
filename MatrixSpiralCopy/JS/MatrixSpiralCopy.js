function spiralCopy(inputMatrix) {
  // your code goes here
  if (inputMatrix[0].length <1 || inputMatrix[0].length > 100) {
     return "inputMatrix width has wrong size";
  }
  if (inputMatrix.length <1 || inputMatrix.length > 100) {
     return "inputMatrix heigth has wrong size";
  }
  
  if (inputMatrix[0].length == 1 && inputMatrix.length == 1 ) {
    return inputMatrix[0,0];
  }
  
  result = [];
  let rightCol = inputMatrix[0].length -1;
  let btmRow = inputMatrix.length - 1;
  
  let leftCol = 0;
  let topRow = 0;
  // First
  
  //while
  
  while (topRow <= btmRow && leftCol <= rightCol) {
    for (let i =leftCol; i <= rightCol; i++) {
       result.push(inputMatrix[topRow][i]);
    } 
    topRow++
    
    for (let j = topRow; j <= btmRow; j++) {
       result.push(inputMatrix[j][rightCol]);
    }  
    rightCol--; 
  
    if (topRow <= btmRow) {
      for (let i = rightCol; i >=  leftCol; i--) {
         result.push(inputMatrix[btmRow][i]);
      }
      btmRow--;
      
    }
   
    if (leftCol <= rightCol) {
      for (let j = btmRow ; j >= topRow; j--) {
         result.push(inputMatrix[j][leftCol]);
      }  
      leftCol ++;
    }
  }
  
  return result;
  
}
