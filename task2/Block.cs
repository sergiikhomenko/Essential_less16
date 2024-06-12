namespace task2;
/*
 * Створіть клас Block із 4 полями сторін, перевизначте в ньому методи:
 * Equals - здатний порівнювати блоки між собою,
 * ToString - повертає інформацію про поля блоку.
 */
public class Block
{
 private int _side1 { get;  }
 private int _side2 { get;  }
 private int _side3 { get;  }
 private int _side4 { get;  }

 public Block(int side1, int side2, int side3, int side4)
 {
  _side1 = side1;
  _side2 = side2;
  _side3 = side3;
  _side4 = side4;
 }

 public override string ToString()
 {
  return $"Сторона1 {_side1} Сторона2 {_side2} Сторона3 {_side3} Сторона4 {_side4}";
 }

 public override bool  Equals(Object obj)
 { 
  if (obj == null || GetType() != obj.GetType())
   return false;
  Block block = (Block)obj;
  return _side1 == block._side1 && _side2 == block._side2 && _side3 == block._side3 && _side4== block._side4;
 }

 public override int GetHashCode()
 {
  int hash=0;
  hash = (_side1 * 3 * _side2 * 4 * _side3 * 5 * _side4 * 6)^_side3;
  return hash;
 }

 public static bool operator ==(Block block1, Block block2)
 {
  if (ReferenceEquals(block1, block2))
  {
   return true;
  }

  if (ReferenceEquals(block1,null)|| ReferenceEquals(block2,null))
  {
   return false;
  }

  return block1.Equals(block2);
 }

 public static bool operator !=(Block block1, Block block2)
 {
  return !(block1 == block2);
 }
}