List<int> choc=new List<int>(6);
choc.Add(2);
choc.Add(2);
choc.Add(1);
choc.Add(3);
choc.Add(2);
int d=4, m=2;
int n=choc.Count-m;
int count=0;

for(int i=0; i<=n; i++) {
  int sum=0;
  int c=i;
  for(int j=0; j<m; j++) {
    c+=j;
    sum+=choc[c];
  }
  if(sum==d) count++;
}
Console.WriteLine(count);


