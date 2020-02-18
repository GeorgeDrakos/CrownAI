using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class QuestionGen {
        public int LHS { get; set; }
        public int RHS { get; set; }
        public char op { get; set; }
        public bool answer { get; set; }

    public QuestionGen(int LHS, int RHS, char op, bool answer) {
            this.LHS = LHS;
            this.RHS = RHS;
            this.op = op;
            this.answer = answer;
        }

        public string toString() {
            return LHS.ToString() + op.ToString() + RHS.ToString();
        }
    }
