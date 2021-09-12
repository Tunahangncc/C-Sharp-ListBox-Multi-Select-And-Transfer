### C SHARP -- FORM ELEMENT LİSTBOX
- The main purpose of this project is to show you how to use the form item list box.

###Project Flow Chart

```flow
st=>start
si=>operation: select element from list
op=>operation: Export to second list click
cond=>condition: Number of selected elements > 0
isi=>operation: Import selected elements to list
cna=>condition: Check the number of attendees
ssf=>operation: Show Second Form
e=>end

st->si->op->cond->isi->cna
cond(yes)->isi
cond(no)->si

cna(yes)->ssf
cna(no)->e
```

