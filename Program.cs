namespace DNA;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter DNA strand: ");
        string dnaStrand = Console.ReadLine().ToUpper();
        string rnaStrand = TranscribeToRNA(dnaStrand);
        Console.WriteLine("RNA complement: " + rnaStrand);
    }

    static string TranscribeToRNA(string dna)
    {
        string rna = "";
        foreach (char nucleotide in dna)
        {
            switch (nucleotide)
            {
                case 'G':
                    rna += "C";
                    break;
                case 'C':
                    rna += "G";
                    break;
                case 'T':
                    rna += "A";
                    break;
                case 'A':
                    rna += "U";
                    break;
                default:
                    Console.WriteLine("Invalid nucleotide found: " + nucleotide);
                    return "Error: Invalid DNA strand";
            }
        }
        return rna;
    }
}