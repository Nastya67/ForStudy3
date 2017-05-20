/**
 * Define a grammar called Hello
 */
grammar Task;
root: mult | vect | matrix_1 EOF;
mult: vect '*' matrix_1;
vect: v ('*' vect)?;
v: '[' (NUMBER (',' NUMBER)*)? ']';
NUMBER: [0-9]+;
matrix_1: matrix ('^-1')?;
matrix: '['(v (',' v)*)? ']';
WS : [ \t\r\n]+ -> skip ;





/*r  : 'hello' ID ;         // match keyword hello followed by an identifier

ID : [a-z]+ ;             // match lower-case identifiers

WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines
*/

