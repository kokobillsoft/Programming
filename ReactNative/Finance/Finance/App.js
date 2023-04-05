import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View } from 'react-native';
import { createDrawerNavigator } from '@react-navigation/drawer';
import { NavigationContainer } from '@react-navigation/native';

import Costs from './Funds/Costs';
import Earnings from './Funds/Earnings';
import Login from './Funds/Login';
import Settings from './Funds/Settings';

export default function App() {
  return (
    <NavigationContainer>
      <Drawer.Navigator initialRouteName='Home'>
        <Drawer.Screen name='Costs' component={Costs}/>
        <Drawer.Screen name='Earnings' component={Earnings}/>
        <Drawer.Screen name='Login' component={Login}/>
        <Drawer.Screen name='Settings' component={Settings}/>
      </Drawer.Navigator>
      <StatusBar style="auto" />
    </NavigationContainer>
  );
}

const Drawer = createDrawerNavigator();
const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
