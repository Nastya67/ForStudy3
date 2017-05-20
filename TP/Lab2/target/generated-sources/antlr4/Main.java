import org.antlr.v4.runtime.ANTLRInputStream;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.CommonTokenStream;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.tree.ParseTree;


public class Main {
	public static void main(String [] argv){
		System.out.printf("hey");
		CharStream stream = new ANTLRInputStream();
		TaskLexer lexer = new TaskLexer(stream);
		TokenStream tokens = new CommonTokenStream(lexer);
		TaskParser parser = new TaskParser(tokens);
		ParseTree tree = parser.root();
	}
}
