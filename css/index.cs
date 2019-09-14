/* http://meyerweb.com/eric/tools/css/reset/ 
   v2.0 | 20110126
   License: none (public domain)
*/
html,
body,
div,
span,
applet,
object,
iframe,
h1,
h2,
h3,
h4,
h5,
h6,
p,
blockquote,
pre,
a,
abbr,
acronym,
address,
big,
cite,
code,
del,
dfn,
em,
img,
ins,
kbd,
q,
s,
samp,
small,
strike,
strong,
sub,
sup,
tt,
var,
b,
u,
i,
center,
dl,
dt,
dd,
ol,
ul,
li,
fieldset,
form,
label,
legend,
table,
caption,
tbody,
tfoot,
thead,
tr,
th,
td,
article,
aside,
canvas,
details,
embed,
figure,
figcaption,
footer,
header,
hgroup,
menu,
nav,
output,
ruby,
section,
summary,
time,
mark,
audio,
video {
  margin: 0;
  padding: 0;
  border: 0;
  font-size: 100%;
  font: inherit;
  vertical-align: baseline;
}
/* HTML5 display-role reset for older browsers */
article,
aside,
details,
figcaption,
figure,
footer,
header,
hgroup,
menu,
nav,
section {
  display: block;
}
body {
  line-height: 1;
}
ol,
ul {
  list-style: none;
}
blockquote,
q {
  quotes: none;
}
blockquote:before,
blockquote:after,
q:before,
q:after {
  content: '';
  content: none;
}
table {
  border-collapse: collapse;
  border-spacing: 0;
}
* {
  box-sizing: border-box;
}
html {
  font-size: 62.5%;
}
html,
body {
  font-family: 'Ubuntu', sans-serif;
  color: #5E6164;
}
h1,
h2,
h3,
h4,
h5 {
  font-family: 'Russo One', sans-serif;
  color: #23293B;
}
h2 {
  font-size: 3.2rem;
}
h3 {
  font-size: 2.8rem;
}
p {
  font-size: 1.6rem;
  line-height: 1.4;
}
.container {
  max-width: 800px;
  width: 100%;
  margin: 0 auto;
}
.head {
  display: flex;
  flex-direction: column;
  padding-top: 2%;
  padding-bottom: 1%;
  margin-left: 25%;
}
.head nav {
  padding-top: 2.5%;
  justify-content: center;
}
.head nav a {
  font-size: 17px;
  color: black;
  text-decoration: none;
  justify-content: space-around;
}
.one {
  margin-right: 8%;
}
.two {
  margin-right: 8%;
}
.three {
  margin-right: 8%;
}
.four {
  margin-right: 8%;
}
.five {
  margin-right: 8%;
}
h1 {
  font-size: 40px;
  margin-left: 15%;
}
@media (max-width: 500px) {
  .head {
    display: flex;
    flex-direction: column;
    padding-top: 2%;
    padding-bottom: 1%;
    margin-left: 20%;
  }
  .head nav {
    padding-top: 2.5%;
    justify-content: center;
  }
  .head nav a {
    font-size: 14px;
    color: black;
    text-decoration: none;
    justify-content: space-around;
  }
  h1 {
    font-size: 40px;
    margin-left: 8%;
  }
}
footer {
  color: #22283B;
  background: #f4f4f4;
  padding: 20px 0;
  border: 1px double #e0e0e0;
  border-radius: 10px;
  display: flex;
  justify-content: center;
  align-items: center;
}
.home .intro h2 {
  padding: 15px;
}
.home .intro p {
  padding: 0 15px;
}
.home .space-images {
  display: flex;
  flex-wrap: wrap;
  width: 100%;
}
.home .space-images img {
  width: 28%;
  margin: 20px 2.5%;
  border-radius: 20px;
  height: 100%;
}
@media (max-width: 500px) {
  .home .space-images {
    display: flex;
    flex-wrap: wrap;
    width: 100%;
    justify-content: center;
    flex-direction: column;
  }
  .home .space-images img {
    width: 40%;
    margin: 20px 2.5%;
    border-radius: 20px;
    height: 100%;
  }
  .home .space-images img .sky {
    display: none;
  }
  .home .space-images img .launch {
    display: none;
  }
}
.home .visit-planets {
  padding: 15px;
}
.home .visit-planets h3 {
  margin-top: 11px;
}
.home .visit-planets p {
  margin-top: 13px;
}
.home .walk {
  margin-top: 60px;
  border-top: 1px solid #dee2e6;
  padding: 50px 60px;
  display: flex;
  justify-content: center;
}
.home .walk .walk-text {
  width: 50%;
}
.home .walk .walk-text h3 {
  margin-bottom: 10px;
}
.home .walk .walk-text p {
  margin-bottom: 26px;
}
.home .walk .walk-text .btn {
  display: block;
  background-color: black;
  margin: 0 10px 20px;
  cursor: pointer;
  width: 100px;
  height: 35px;
  font-size: 17px;
  border-radius: 10px;
  color: white;
  align-items: center;
  display: flex;
  justify-content: center;
}
.home .walk .walk-text .btn:hover {
  background-color: white;
  color: black;
}
.home .walk .walk-img {
  width: 46%;
  margin-left: 4%;
}
.home .walk .walk-img img {
  width: 100%;
  height: auto;
  border-radius: 10px;
}
