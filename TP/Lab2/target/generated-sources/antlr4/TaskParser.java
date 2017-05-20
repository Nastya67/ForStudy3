// Generated from Task.g4 by ANTLR 4.4
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class TaskParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.4", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__4=1, T__3=2, T__2=3, T__1=4, T__0=5, NUMBER=6, WS=7;
	public static final String[] tokenNames = {
		"<INVALID>", "'^-1'", "'*'", "'['", "','", "']'", "NUMBER", "WS"
	};
	public static final int
		RULE_root = 0, RULE_mult = 1, RULE_vect = 2, RULE_v = 3, RULE_matrix_1 = 4, 
		RULE_matrix = 5;
	public static final String[] ruleNames = {
		"root", "mult", "vect", "v", "matrix_1", "matrix"
	};

	@Override
	public String getGrammarFileName() { return "Task.g4"; }

	@Override
	public String[] getTokenNames() { return tokenNames; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public TaskParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}
	public static class RootContext extends ParserRuleContext {
		public MultContext mult() {
			return getRuleContext(MultContext.class,0);
		}
		public TerminalNode EOF() { return getToken(TaskParser.EOF, 0); }
		public Matrix_1Context matrix_1() {
			return getRuleContext(Matrix_1Context.class,0);
		}
		public VectContext vect() {
			return getRuleContext(VectContext.class,0);
		}
		public RootContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_root; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TaskListener ) ((TaskListener)listener).enterRoot(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TaskListener ) ((TaskListener)listener).exitRoot(this);
		}
	}

	public final RootContext root() throws RecognitionException {
		RootContext _localctx = new RootContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_root);
		try {
			setState(17);
			switch ( getInterpreter().adaptivePredict(_input,0,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(12); mult();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(13); vect();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(14); matrix_1();
				setState(15); match(EOF);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MultContext extends ParserRuleContext {
		public Matrix_1Context matrix_1() {
			return getRuleContext(Matrix_1Context.class,0);
		}
		public VectContext vect() {
			return getRuleContext(VectContext.class,0);
		}
		public MultContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_mult; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TaskListener ) ((TaskListener)listener).enterMult(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TaskListener ) ((TaskListener)listener).exitMult(this);
		}
	}

	public final MultContext mult() throws RecognitionException {
		MultContext _localctx = new MultContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_mult);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(19); vect();
			setState(20); match(T__3);
			setState(21); matrix_1();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class VectContext extends ParserRuleContext {
		public VContext v() {
			return getRuleContext(VContext.class,0);
		}
		public VectContext vect() {
			return getRuleContext(VectContext.class,0);
		}
		public VectContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_vect; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TaskListener ) ((TaskListener)listener).enterVect(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TaskListener ) ((TaskListener)listener).exitVect(this);
		}
	}

	public final VectContext vect() throws RecognitionException {
		VectContext _localctx = new VectContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_vect);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(23); v();
			setState(26);
			switch ( getInterpreter().adaptivePredict(_input,1,_ctx) ) {
			case 1:
				{
				setState(24); match(T__3);
				setState(25); vect();
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class VContext extends ParserRuleContext {
		public TerminalNode NUMBER(int i) {
			return getToken(TaskParser.NUMBER, i);
		}
		public List<TerminalNode> NUMBER() { return getTokens(TaskParser.NUMBER); }
		public VContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_v; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TaskListener ) ((TaskListener)listener).enterV(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TaskListener ) ((TaskListener)listener).exitV(this);
		}
	}

	public final VContext v() throws RecognitionException {
		VContext _localctx = new VContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_v);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(28); match(T__2);
			setState(37);
			_la = _input.LA(1);
			if (_la==NUMBER) {
				{
				setState(29); match(NUMBER);
				setState(34);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==T__1) {
					{
					{
					setState(30); match(T__1);
					setState(31); match(NUMBER);
					}
					}
					setState(36);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				}
			}

			setState(39); match(T__0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Matrix_1Context extends ParserRuleContext {
		public MatrixContext matrix() {
			return getRuleContext(MatrixContext.class,0);
		}
		public Matrix_1Context(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_matrix_1; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TaskListener ) ((TaskListener)listener).enterMatrix_1(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TaskListener ) ((TaskListener)listener).exitMatrix_1(this);
		}
	}

	public final Matrix_1Context matrix_1() throws RecognitionException {
		Matrix_1Context _localctx = new Matrix_1Context(_ctx, getState());
		enterRule(_localctx, 8, RULE_matrix_1);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(41); matrix();
			setState(43);
			_la = _input.LA(1);
			if (_la==T__4) {
				{
				setState(42); match(T__4);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MatrixContext extends ParserRuleContext {
		public VContext v(int i) {
			return getRuleContext(VContext.class,i);
		}
		public List<VContext> v() {
			return getRuleContexts(VContext.class);
		}
		public MatrixContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_matrix; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TaskListener ) ((TaskListener)listener).enterMatrix(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TaskListener ) ((TaskListener)listener).exitMatrix(this);
		}
	}

	public final MatrixContext matrix() throws RecognitionException {
		MatrixContext _localctx = new MatrixContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_matrix);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(45); match(T__2);
			setState(54);
			_la = _input.LA(1);
			if (_la==T__2) {
				{
				setState(46); v();
				setState(51);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==T__1) {
					{
					{
					setState(47); match(T__1);
					setState(48); v();
					}
					}
					setState(53);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				}
			}

			setState(56); match(T__0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\3\u0430\ud6d1\u8206\uad2d\u4417\uaef1\u8d80\uaadd\3\t=\4\2\t\2\4\3\t"+
		"\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\3\2\3\2\3\2\3\2\3\2\5\2\24\n\2\3\3"+
		"\3\3\3\3\3\3\3\4\3\4\3\4\5\4\35\n\4\3\5\3\5\3\5\3\5\7\5#\n\5\f\5\16\5"+
		"&\13\5\5\5(\n\5\3\5\3\5\3\6\3\6\5\6.\n\6\3\7\3\7\3\7\3\7\7\7\64\n\7\f"+
		"\7\16\7\67\13\7\5\79\n\7\3\7\3\7\3\7\2\2\b\2\4\6\b\n\f\2\2>\2\23\3\2\2"+
		"\2\4\25\3\2\2\2\6\31\3\2\2\2\b\36\3\2\2\2\n+\3\2\2\2\f/\3\2\2\2\16\24"+
		"\5\4\3\2\17\24\5\6\4\2\20\21\5\n\6\2\21\22\7\2\2\3\22\24\3\2\2\2\23\16"+
		"\3\2\2\2\23\17\3\2\2\2\23\20\3\2\2\2\24\3\3\2\2\2\25\26\5\6\4\2\26\27"+
		"\7\4\2\2\27\30\5\n\6\2\30\5\3\2\2\2\31\34\5\b\5\2\32\33\7\4\2\2\33\35"+
		"\5\6\4\2\34\32\3\2\2\2\34\35\3\2\2\2\35\7\3\2\2\2\36\'\7\5\2\2\37$\7\b"+
		"\2\2 !\7\6\2\2!#\7\b\2\2\" \3\2\2\2#&\3\2\2\2$\"\3\2\2\2$%\3\2\2\2%(\3"+
		"\2\2\2&$\3\2\2\2\'\37\3\2\2\2\'(\3\2\2\2()\3\2\2\2)*\7\7\2\2*\t\3\2\2"+
		"\2+-\5\f\7\2,.\7\3\2\2-,\3\2\2\2-.\3\2\2\2.\13\3\2\2\2/8\7\5\2\2\60\65"+
		"\5\b\5\2\61\62\7\6\2\2\62\64\5\b\5\2\63\61\3\2\2\2\64\67\3\2\2\2\65\63"+
		"\3\2\2\2\65\66\3\2\2\2\669\3\2\2\2\67\65\3\2\2\28\60\3\2\2\289\3\2\2\2"+
		"9:\3\2\2\2:;\7\7\2\2;\r\3\2\2\2\t\23\34$\'-\658";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}