/* Reset básico */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

/* Estilos gerais */
body {
    font-family: 'Arial', sans-serif;
    line-height: 1.6;
    background-color: #f4f4f4;
    color: #333;
}

a {
    text-decoration: none;
    color: inherit;
}

h1, h2, h3 {
    font-weight: bold;
}

/* Cabeçalho */
header {
    display: flex;
    justify-content: space-between;
    padding: 20px;
    background-color: #5C8A2E;
    color: white;
}

header .logo img {
    max-height: 50px;
}

nav ul {
    list-style-type: none;
    display: flex;
}

nav ul li {
    margin: 0 15px;
}

nav ul li a {
    color: white;
    font-size: 18px;
}

.search-bar input {
    padding: 5px;
    font-size: 16px;
    border: none;
    border-radius: 5px;
}

/* Seção de Introdução */
#introducao {
    display: flex;
    justify-content: space-between;
    padding: 50px 20px;
    background-color: #eef2d4;
}

#introducao .intro-text {
    max-width: 50%;
}

#introducao .intro-text h1 {
    font-size: 36px;
    margin-bottom: 20px;
}

#introducao .intro-text p {
    margin-bottom: 20px;
}

.cta-btn {
    display: inline-block;
    padding: 10px 20px;
    background-color: #5C8A2E;
    color: white;
    font-size: 16px;
    border-radius: 5px;
    transition: background-color 0.3s ease;
}

.cta-btn:hover {
    background-color: #4a7a28;
}

#introducao .intro-image img {
    max-width: 100%;
    border-radius: 8px;
}

/* Seção de Projetos */
#projetos {
    padding: 50px 20px;
    text-align: center;
}

#projetos h2 {
    font-size: 32px;
    margin-bottom: 30px;
}

.project {
    display: inline-block;
    width: 45%;
    margin: 20px;
    background-color: #ffffff;
    padding: 20px;
    border-radius: 8px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
}

.project img {
    max-width: 100%;
    border-radius: 8px;
}

.project h3 {
    font-size: 24px;
    margin: 15px 0;
}

.project p {
    font-size: 16px;
    margin-bottom: 15px;
}

/* Seção de Blog */
#blog {
    padding: 50px 20px;
    background-color: #fff;
}

.blog-post {
    margin-bottom: 30px;
}

.blog-post h3 {
    font-size: 28px;
    margin-bottom: 10px;
}

.blog-post a {
    font-size: 16px;
    color: #5C8A2E;
}

/* Rodapé */
footer {
    background-color: #333;
    color: white;
    padding: 30px 20px;
    text-align: center;
}

footer ul {
    list-style-type: none;
    margin-bottom: 20px;
}

footer ul li {
    display: inline;
    margin: 0 10px;
}

footer .social-media {
    margin-bottom: 10px;
}

footer .social-media a {
    color: white;
    margin: 0 10px;
}