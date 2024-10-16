using EjercicioClase;

SuperHeroe superheroe1 = new SuperHeroe();
superheroe1.Nombre = "Superman";
superheroe1.identidadSecreta = "Clark Kent";
superheroe1.Ciudad = "Metrópolis";
superheroe1.puedeVolar = true;
superheroe1.superpoder.nombre = "Superfuerza";
superheroe1.superpoder.descripcion = "Fuerza sobrehumana, visión de rayos X, vuelo";
superheroe1.superpoder.nivel = 10;
superheroe1.Imprimir();

SuperHeroe superheroe2 = new SuperHeroe();
superheroe2.Nombre = "Wonder Woman";
superheroe2.identidadSecreta = "Diana Prince";
superheroe2.Ciudad = "Themyscira";
superheroe2.puedeVolar = true;
superheroe2.superpoder.nombre = "Fuerza amazona";
superheroe2.superpoder.descripcion = "Fuerza sobrehumana, lazo de la verdad, brazaletes deflectores";
superheroe2.superpoder.nivel = 9;
superheroe2.Imprimir();

SuperHeroe superheroe3 = new SuperHeroe();
superheroe3.Nombre = "Batman";
superheroe3.identidadSecreta = "Bruce Wayne";
superheroe3.Ciudad = "Gotham";
superheroe3.puedeVolar = false;
superheroe3.superpoder.nombre = "Intelecto superior, Millonario";
superheroe3.superpoder.descripcion = "Genio detective, maestro en artes marciales, gadgets avanzados";
superheroe3.superpoder.nivel = 7;
superheroe3.Imprimir();