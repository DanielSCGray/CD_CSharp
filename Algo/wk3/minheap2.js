/**
 * Class to represent a MinHeap which is a Priority Queue optimized for fast
 * retrieval of the minimum value. It is implemented using an array but it is
 * best visualized as a tree structure where each 'node' has left and right
 * children except the 'node' may only have a left child.
 * - parent is located at: Math.floor(i / 2);
 * - left child is located at: i * 2
 * - right child is located at: i * 2 + 1
 * https://www.cs.usfca.edu/~galles/visualization/Heap.html
 */
class MinHeap {
    constructor() {
        /**
         * 0th index not used, so null is a placeholder. Not using 0th index makes
         * calculating the left and right children's index cleaner.
         * This also effectively makes our array start at index 1.
         */
        this.heap = [null];
    }

    idxOfParent(index) {
        return Math.floor(index / 2);
    }

    idxOfLeftChild(index) {
        return index * 2;
    }

    idxOfRightChild(index) {
        return index * 2 + 1;
    }

    /**
     * Retrieves the top (minimum number) in the heap without removing it.
     * - Time: O(1) constant.
     * - Space: O(1) constant.
     * @returns {?number} Null if empty.
     */
    top() {
        return this.heap.length == 1 ? null : this.heap[1];
    }

    /**
     * Inserts a new number into the heap and maintains the heaps order.
     * 1. Push new num to back of the array
     * 2. Iteratively swap the new num with its parent while it is smaller than
     *    its parent.
     * - Time: O(log n) logarithmic due to shiftUp / iterative swapping.
     * - Space: O(1) constant.
     * @param {number} num The num to add.
     */
    insert(num) {
        //add item to heap
        this.heap.push(num);

        //get index of new item
        let insertedIdx = this.heap.length - 1;
        //get index of new item's parent
        let parentIdx = this.idxOfParent(insertedIdx);
        //while value at insertion point less than its parent, swap and recalculate parent
        while (this.heap[insertedIdx] < this.heap[parentIdx] && parentIdx >= 1) {
            //perform swap
            let temp = this.heap[insertedIdx];
            this.heap[insertedIdx] = this.heap[parentIdx];
            this.heap[parentIdx] = temp;
            //swapped value is now at old parent
            insertedIdx = parentIdx;
            //get parent of old parent
            parentIdx = this.idxOfParent(insertedIdx);
        }
        return this;
    }

    /**
   * Extracts the min num from the heap and then re-orders the heap to
   * maintain order so the next min is ready to be extracted.
   * 1. Save the first node to a temp var.
   * 2. Pop last node off and set idx1 equal to the popped value.
   * 3. Iteratively swap the old last node that is now at idx1 with it's
   *    smallest child IF the smallest child is smaller than it.
   * - Time: O(log n) logarithmic due to shiftDown.
   * - Space: O(1) constant.
   * @returns {?number} The min number or null if empty.
   */
    extract() { 
        if (this.heap.length ==1){
            return null
        }
        if (this.heap.length ==2){
            return this.heap.pop()
        }
        let min = this.heap[1]
        this.heap[1] = this.heap.pop()
        let currentIdx = 1
        let rightIdx = this.idxOfRightChild(currentIdx)
        let leftIdx = this.idxOfLeftChild(currentIdx)
        while(this.heap[leftIdx] < this.heap[currentIdx] || this.heap[rightIdx] < this.heap[currentIdx]){
            if(this.heap[leftIdx] < this.heap[rightIdx]){
                [this.heap[leftIdx], this.heap[currentIdx]] = [this.heap[leftIdx], this.heap[currentIdx]]
                currentIdx = leftIdx
            } else {
                [this.heap[rightIdx], this.heap[currentIdx]] = [this.heap[rightIdx], this.heap[currentIdx]]
                currentIdx = rightIdx
            }
            leftIdx = this.idxOfLeftChild(currentIdx)
            rightIdx = this.idxOfRightChild(currentIdx)
        }
        return min
    }

    /**
     * Logs the tree horizontally with the root on the left and the index in
     * parenthesis using reverse inorder traversal.
     */
    printHorizontalTree(parentIdx = 1, spaceCnt = 0, spaceIncr = 10) {
        if (parentIdx > this.heap.length - 1) {
            return;
        }

        spaceCnt += spaceIncr;
        this.printHorizontalTree(parentIdx * 2 + 1, spaceCnt);

        console.log(
            " ".repeat(spaceCnt < spaceIncr ? 0 : spaceCnt - spaceIncr) +
            `${this.heap[parentIdx]} (${parentIdx})`
        );

        this.printHorizontalTree(parentIdx * 2, spaceCnt);
    }
}

let testHeap = new MinHeap();

testHeap.insert(10);

testHeap.printHorizontalTree();
testHeap.insert(7);
testHeap.printHorizontalTree();
testHeap.insert(3);
testHeap.printHorizontalTree();