var $dungeon = document.createElement("div");
$dungeon.setAttribute("id", "dungeon");

function createDungeon(rows, columns) {
	for (var x = 0; x < rows; x++) {
		var randomRow = randomizeElements(columns);
		var readyRow = clearPaths(randomRow);
		for (var y = 0; y < columns; y++) {
			renderElement(readyRow[y]);
		}
		var nextRow = document.createElement("br");
		$dungeon.append(nextRow);
	}
	$("#appendHere").append($dungeon);
}

function randomizeElements(columns) {
	var elemKey = new Array(columns);
	for (var i = 0; i < columns; i++) {
		elemKey[i] = Math.floor((Math.random() * 2) + 1);
	}
	return elemKey;
}

function clearPaths(array) {
	for (var z = 1; z <= array.length; z++) {
		if (array[z - 1] != 1 && array[z] == 1 && array[z + 1] != 1) {
			array[z] = 2;
		}
	}
	return array;
}

function renderElement(key) {
	switch (key) {
		case 1:
			var wall = document.createElement("div");
			wall.className = "wall";
			$dungeon.append(wall);
			break;
		case 2:
			var path = document.createElement("div");
			path.className = "path";
			$dungeon.append(path);
			break;
		default:
			var water = document.createElement("div");
			water.className = "water";
			$dungeon.append(water);
			break;
	}
}

