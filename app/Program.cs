int n=Convert.ToInt32(Console.ReadLine());
for(int i=0; i<n; i++) {
  for(int j=0; j<=i; j++) {
    if(j==0&&i!=n-1) {
      Console.Write("a");
    } else if(i==n-1&&j!=n-1) {
      Console.Write("b");
    } else if(i!=0&&i==j) {
      Console.Write("c");
    } else {
      Console.Write(" ");
    }
  }
  Console.Write("\n");
}