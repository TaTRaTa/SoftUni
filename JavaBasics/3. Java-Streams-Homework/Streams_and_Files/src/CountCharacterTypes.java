import java.io.*;

/**
 * Created by lenovo on 24.10.2015 ã..
 */
public class CountCharacterTypes {
    public static void main(String[] args) throws IOException {
        BufferedReader in = new BufferedReader(new FileReader("src\\words.txt"));
        PrintWriter print = new PrintWriter(new FileWriter("src\\count-chars.txt"));
        int vowels = 0;
        int consonants = 0;
        int punctuation = 0;
        try {

            String line = in.readLine();
            while (line != null){
                line = line.replaceAll(" ","");
                for (int i = 0; i < line.length();i++) {
                    switch (line.charAt(i)){
                        case 'a': vowels++; break;
                        case 'e': vowels++; break;
                        case 'o': vowels++; break;
                        case 'i': vowels++; break;
                        case 'u': vowels++; break;
                        case '!': punctuation++; break;
                        case ',': punctuation++; break;
                        case '.': punctuation++; break;
                        case '?': punctuation++; break;
                        default:
                            consonants++;
                            break;
                    }
                }
                line = in.readLine();
            }
            //System.out.printf("%d\n%d\n%d\n", vowels, consonants, punctuation); //output in console
            //print.printf("%d\n%d\n%d\n", vowels, consonants, punctuation);  <<--- isn't work
            print.println(vowels);
            print.println(consonants);
            print.println(punctuation);



        }finally {
            in.close();
            print.close();
        }
    }
}
