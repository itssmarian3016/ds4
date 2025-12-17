
const apiLibros='http://localhost:5000/api/libros';
const apiPrestamos='http://localhost:5000/api/prestamos';

document.getElementById('libroForm').onsubmit=async e=>{
 e.preventDefault();
 await fetch(apiLibros,{method:'POST',headers:{'Content-Type':'application/json'},
 body:JSON.stringify({titulo:titulo.value,codigo:codigo.value,autor:autor.value,anio:+anio.value||0,genero:genero.value})});
}

const pBody=document.getElementById('prestamosBody');
document.getElementById('prestamoForm').onsubmit=async e=>{
 e.preventDefault();
 await fetch(apiPrestamos,{method:'POST',headers:{'Content-Type':'application/json'},
 body:JSON.stringify({usuario:usuario.value,libroId:+libroId.value,fecha:fecha.value})});
 cargarPrestamos();
}

function cargarPrestamos(){
 fetch(apiPrestamos).then(r=>r.json()).then(d=>{
  pBody.innerHTML='';
  if(!d.length){pBody.innerHTML='<tr><td colspan=4>Sin registros</td></tr>';return;}
  d.forEach((p,i)=>{
   pBody.innerHTML+=`<tr><td>${i+1}</td><td>${p.usuario}</td><td>${p.libroId}</td><td>${p.fecha}</td></tr>`;
  });
 });
}
cargarPrestamos();
