
/**Encontrei um erro. Quando eu insiro um nó xml do tipo SVG ele funciona corretamente,
 * porém quado eu insiro um nó xml ou html puro com filhos SVG, o browser não desenha
 * os elementos SVG, mesmo o texto HTML estando correto.
 */
function buscaMapa(){
    return  window.document.getElementById("mapa");
}

function criaElementoSVG(nome){
    return document.createElementNS("http://www.w3.org/2000/svg",nome);
}

function criaElemento(nome){
    return document.createElementNS("http://www.w3.org/1999/xhtml", nome);
}

window.lineDraw = (id,x1,y1,x2,y2,stroke,width) => {

    const mapa = window.document.getElementById("mapa");
    const newline = document.createElementNS("http://www.w3.org/2000/svg","line");

  
    newline.setAttribute("x1",x1);
    newline.setAttribute("y1",y1);
    newline.setAttribute("x2",x2);
    newline.setAttribute("y2",y2);
    newline.setAttribute("stroke",stroke);
    newline.setAttribute("stroke-width",width);
    newline.setAttribute("id",id);
    newline.setAttribute("onclick", "window.location.href=''");

    mapa.append(newline);
    
}

window.rectangleDraw = (id,x,y,width,height,rx="0",ry="0") => {
    const mapa = buscaMapa();
    const newrec = document.createElementNS("http://www.w3.org/2000/svg","rect");
    newrec.setAttribute("x",x);
    newrec.setAttribute("y",y);
    newrec.setAttribute("width",width);
    newrec.setAttribute("height",height);
    newrec.setAttribute("rx",rx);
    newrec.setAttribute("ry",ry);
    newrec.setAttribute("id",id);
    newrec.setAttribute("onclick", "window.location.href=''");

    mapa.appendChild(newrec);
}

window.circleDraw = (id,cx,cy,r) => {
    const mapa = buscaMapa();
    const novo = criaElementoSVG("circle");
    novo.setAttribute("cx",cx);
    novo.setAttribute("cy",cy);
    novo.setAttribute("r",r);
    novo.setAttribute("id",id);
    novo.setAttribute("onclick", "window.location.href=''");

    mapa.appendChild(novo);
}

window.ellipseDraw = () => {
    console.log("Desenha uma elipse");
}

window.polyLineDraw = () => {
    console.log("Desenha uma poli linha");
}

window.polygonDraw = () => {
    console.log("Desenha um poligono");
}

window.pathDraw = () => {
    console.log("Desenha um path");
}