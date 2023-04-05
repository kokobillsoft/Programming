import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, TouchableOpacity } from 'react-native';

export default function ListItem( {el, deleteHandler} ) {
  return (
    <TouchableOpacity onLongPress={() => deleteHandler(el.key)}>
        <Text style={styles.text}> {el.text} </Text>
    </TouchableOpacity>
  );
}

const styles = StyleSheet.create({
    text: {
        padding: 20,
        textAlign: 'center',
        borderRadius: 5,
        backgroundColor: '#fafafa',
        borderWidth: 1,
        marginTop: 1,
        width: '98%',
        marginLeft: '1%'
        
    }
})
