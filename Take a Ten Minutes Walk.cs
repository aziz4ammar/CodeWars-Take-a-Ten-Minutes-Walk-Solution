using System;

public class Kata
{
  public static bool IsValidWalk(string[] walk)
  {
    if (walk.Length != 10) return false; // Make sure the walk is exactly 10 minutes long

    int x = 0, y = 0; // Starting position
    foreach (string direction in walk)
    {
      switch (direction)
      {
        case "n":
          y++;
          break;
        case "s":
          y--;
          break;
        case "e":
          x++;
          break;
        case "w":
          x--;
          break;
      }
    }

    // If we end up back at the starting position, the walk is valid
    return (x == 0 && y == 0);
  }
}
