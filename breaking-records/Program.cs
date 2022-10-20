int[] records={10, 5, 20, 20, 4, 5, 2, 25, 1};

int n=records.Length;
int min=records[0], max=records[0];
int cMin=0, cMax=0;
for(int i=1; i<n; i++) {
  if(max<records[i]) {
    cMax++;
    max=records[i];
  }
  if(min>records[i]) {
    cMin++;
    min=records[i];
  }
}
Console.WriteLine(cMax + " " + cMin);

