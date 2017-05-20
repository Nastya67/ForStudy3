// Generated from Task.g4 by ANTLR 4.4
import org.antlr.v4.runtime.misc.NotNull;
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link TaskParser}.
 */
public interface TaskListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link TaskParser#mult}.
	 * @param ctx the parse tree
	 */
	void enterMult(@NotNull TaskParser.MultContext ctx);
	/**
	 * Exit a parse tree produced by {@link TaskParser#mult}.
	 * @param ctx the parse tree
	 */
	void exitMult(@NotNull TaskParser.MultContext ctx);
	/**
	 * Enter a parse tree produced by {@link TaskParser#matrix_1}.
	 * @param ctx the parse tree
	 */
	void enterMatrix_1(@NotNull TaskParser.Matrix_1Context ctx);
	/**
	 * Exit a parse tree produced by {@link TaskParser#matrix_1}.
	 * @param ctx the parse tree
	 */
	void exitMatrix_1(@NotNull TaskParser.Matrix_1Context ctx);
	/**
	 * Enter a parse tree produced by {@link TaskParser#v}.
	 * @param ctx the parse tree
	 */
	void enterV(@NotNull TaskParser.VContext ctx);
	/**
	 * Exit a parse tree produced by {@link TaskParser#v}.
	 * @param ctx the parse tree
	 */
	void exitV(@NotNull TaskParser.VContext ctx);
	/**
	 * Enter a parse tree produced by {@link TaskParser#root}.
	 * @param ctx the parse tree
	 */
	void enterRoot(@NotNull TaskParser.RootContext ctx);
	/**
	 * Exit a parse tree produced by {@link TaskParser#root}.
	 * @param ctx the parse tree
	 */
	void exitRoot(@NotNull TaskParser.RootContext ctx);
	/**
	 * Enter a parse tree produced by {@link TaskParser#vect}.
	 * @param ctx the parse tree
	 */
	void enterVect(@NotNull TaskParser.VectContext ctx);
	/**
	 * Exit a parse tree produced by {@link TaskParser#vect}.
	 * @param ctx the parse tree
	 */
	void exitVect(@NotNull TaskParser.VectContext ctx);
	/**
	 * Enter a parse tree produced by {@link TaskParser#matrix}.
	 * @param ctx the parse tree
	 */
	void enterMatrix(@NotNull TaskParser.MatrixContext ctx);
	/**
	 * Exit a parse tree produced by {@link TaskParser#matrix}.
	 * @param ctx the parse tree
	 */
	void exitMatrix(@NotNull TaskParser.MatrixContext ctx);
}