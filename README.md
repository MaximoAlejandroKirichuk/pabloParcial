# Parcial
Parte Teórica
1- ¿Qué son y para que se pueden utilizar las clases anidadas?
2- ¿Cómo y para qué se puede aprovechar en la práctica el polimorfismo?
3- ¿Para qué se usa una clase abstracta?
4- ¿Qué es la sobreescritura?
Parte Practica
Guía de Resolución:
1. Introducción
Desarrollo de un Sistema de Becas para Estudiantes Universitarios
El objetivo de este proyecto es crear un sistema de gestión de becas para estudiantes universitarios. Para ello,
se requiere la implementación de dos clases fundamentales:
1. Clase `Alumno`: Esta clase representará a los estudiantes.
2. Clase `Beca`: Esta clase representará las becas disponibles.
Adicionalmente, se utilizarán los siguientes componentes para la interacción con el usuario:
- TextBox: Para ingresar los datos de los estudiantes y las becas.
- DataGridView: Para mostrar la información de los alumnos y las becas de manera tabular.
A continuación, se presentará y desarrollará el código necesario para la implementación de este sistema.
Clase Alumno:
Atributos
Constructor
Clase Beca:
Atributos:
Constructor
Los métodos pueden estar en cualquier clase.
Formulario Principal:
TextBox para ingresar los datos del alumno y becas.
DataGridView para mostrar los alumnos y sus becas.
Botones para agregar alumnos y otorgar becas.
El formulario principal contiene los controles de la interfaz de usuario (TextBox, DataGridView, Botones) y la
lógica para interactuar con los objetos Alumno y Beca.
Inicialización de Grilla de Alumnos:
Se crea una grilla (DataGridView) para mostrar los datos de los alumnos. Aquí se configuran las columnas
necesarias.
Agregar Alumno:
Al hacer clic en el botón "Agregar Alumno", se lee la información de los TextBox correspondientes y se crea un
nuevo objeto Alumno. Luego se agrega este alumno a la lista de alumnos y se muestra en la grilla.
Otorgar Beca:
Cuando se selecciona un alumno de la grilla y se hace clic en el botón "Otorgar Beca", se crea una nueva
instancia de Beca y se asigna al alumno seleccionado. Luego se actualiza la grilla para reflejar este cambio.
Ejemplo “este ejemplo es ilustrativo”, no es necesario que sea el mismo a desarrollar.
Utilizar Try … Catch para administrar las excepciones del sistema.
Observe la usabilidad (fácil de utilizar por el usuario, cantidad de clic para una operación, suma claridad en lo
que el usuario debe realizar para utilizar en sistema).
2. Plan de trabajo
Desarrollar el código correspondiente al programa solicitado.
Documentar el código considerando colocar no menos de un comentario cada tres líneas de código.
Probar el código para detectar fallas que no permitan lograr los objetivos planteados.
3. Forma de entrega:
Colocar en un archivo .zip el desarrollo completo y el documento del enunciado del parcial (no utilice ninguna
versión que no sea la estándar en .zip ni otras extensiones)
Nombre del Archivo: Asignatura_1erParcial_Apellido_Nombre.zip
Ejemplo: POO_1erParcial_Perez_Juan.zip
